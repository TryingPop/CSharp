# 날짜 : 22.07.18
# 내용 : SQL 기본 실습하기

# 실습 1-1
# ` : 따옴표 키가 아닌 Tap키 위에 있는 Backtick
# 대소문자 구분 X
# userdb 생성
CREATE DATABASE `UserDb`;
# userdb 제거
DROP DATABASE `UserDb`;

# 실습 1-2
# VARCHAR : 가변길이
# CHAR : 고정길이
CREATE TABLE `User1` (
	`uid` 	VARCHAR(10),
	`name`	VARCHAR(10),
	`hp`		CHAR(13),
	`age`		INT
	);
	
DROP TABLE `User1`

# 실습 1-3
# 기본값은 Null
INSERT INTO `User1` VALUES ('A101', '김유신', '010-1234-1111', 25);
INSERT INTO `User1` VALUES ('A102', '김춘추', '010-1234-2222', 23);
INSERT INTO `User1` VALUES ('A101', '장보고', '010-1234-3333', 32);
INSERT INTO `User1` (`uid`, `name`, `age`) VALUES ('A104', '강감찬', 45);
# 이순신의 경우 맵핑해서 쿼리
# 데이터만 따옴표 이외는 backtick
INSERT INTO `User1` SET 
								`uid` = 'A105', 
								`name` = '이순신', 
								`hp` = '010-1234-5555';

# 실습 1-4
# * : all
# 모든 User1에 자료 조사
SELECT * FROM `User1`;
SELECT * FROM `User1` WHERE `uid` = 'A101';
SELECT * FROM `User1` WHERE `name` = '김춘추';
SELECT * FROM `User1` WHERE `age` >= 30;
SELECT `uid`, `name`, `age` FROM `User1`;

# 실습 1-5
# user1에서 uid = A104인 사람에 대해 hp = 010-1234-4444로 수정해라
UPDATE `User1` SET `hp` = '010-1234-4444' 
					WHERE `uid` = 'A104';
					
UPDATE `User1` SET `age` = 51 
					WHERE `uid` = 'A105';

UPDATE `User1` SET 	`hp` = '010-1234-1001', 
						 	`age` = 27 
					WHERE 
							`uid` = 'A101';

# 실습 1-6
# A101 모두 삭제된다
DELETE FROM `User1` WHERE `uid` = 'A101';
# 조건이 모두 만족되면 삭제!
DELETE FROM `user1` WHERE `uid` = 'A102' AND `age` = 25;
DELETE FROM `User1` WHERE `age` >= 30;
