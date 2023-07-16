# database 삭제
userdbDROP DATABASE `userdb`;

# database 생성
CREATE DATABASE `userdb`;

# 테이블 생성
# 앞에서 만든 userdb 데이터베이스를 사용
USE `userdb`;
# name, ip, 벤 정보를 갖는 info 테이블 생성
CREATE TABLE `info` (
	`name` 	VARCHAR(10),
	`ip`		CHAR(15),
	`ban`		TINYINT
	);

# 채팅 내역을 남기는 테이블
# 작성자 ip, 대화내용, 옵션(0 : 전체말, 1 : 귓속말), 타겟 ip(null : 전체말, 귓속말 대상 ip)
CREATE TABLE `chat` (
	`ip`			CHAR(15),
	`chat`		VARCHAR(50),
	`opt`			INT,
	`target`		CHAR(15)
	);