# 날짜 : 22.07.19
# 내용 : 테이블 설정

# 실습하기 2-1
CREATE TABLE `User2` ( 
			`uid` 	VARCHAR(10) PRIMARY KEY,
	  	   `name` 	VARCHAR(10),
			`hp` 		CHAR(13),
			`age` 	INT
			);
			
INSERT INTO `user2` VALUES ('a101', '김유신', '010-1234-1001', 25);
INSERT INTO `user2` VALUES ('a102', '김춘추', '010-1234-1002', 23);
INSERT INTO `user2` VALUES ('a103', '장보고', '010-1234-1003', 35);
INSERT INTO `user2` VALUES ('a104', '강감찬', '010-1234-1004', 45);
INSERT INTO `user2` VALUES ('a105', '이순신', '010-1234-1005', 55);
INSERT INTO `user2` VALUES ('a106', '정약용', '010-1234-1003', 33);

# Primary Key로 막아서 아래 코드 실행 불가능
# INSERT INTO `user2` VALUES ('a103', '이성계', '010-1234-1006', 55);

						
# 실습하기 2-2
CREATE TABLE `User3` ( 
			`uid` 	VARCHAR(10) PRIMARY KEY,
	  	   `name` 	VARCHAR(10),
			`hp` 		CHAR(13) UNIQUE,
			`age` 	INT
			);

INSERT INTO `user3` VALUES ('a101', '김유신', '010-1234-1001', 25);
INSERT INTO `user3` VALUES ('a102', '김춘추', '010-1234-1002', 23);
INSERT INTO `user3` VALUES ('a103', '장보고', '010-1234-1003', 35);
INSERT INTO `user3` VALUES ('a104', '강감찬', '010-1234-1004', 45);
INSERT INTO `user3` VALUES ('a105', '이순신', '010-1234-1005', 55);

# `hp`에서 중복이 일어나서 Unique 설정에의해 에러메세지 나온다
# INSERT INTO `user3` VALUES ('a106', '정약용', '010-1234-1003', 33);


# 실습하기 2-3
CREATE TABLE `parent` (
			`pid` VARCHAR(10) PRIMARY KEY,
			`name` VARCHAR(10),
			`hp` CHAR(13) UNIQUE
			);
			
CREATE TABLE `child` (
			`cid` VARCHAR(10) PRIMARY KEY,
			`name` VARCHAR(10),
			`hp` CHAR(13) UNIQUE,
			`pid` VARCHAR(10),
			FOREIGN KEY (`pid`) REFERENCES `parent` (`pid`)
			);
			
INSERT INTO `parent` VALUES ('p101', '김유신', '010-1234-1001');
INSERT INTO `parent` VALUES ('p102', '김춘추', '010-1234-1002');
INSERT INTO `parent` VALUES ('p103', '장보고', '010-1234-1003');

INSERT INTO `child` VALUES ('c101', '김길동', '010-1010-1001', 'p101');
INSERT INTO `child` VALUES ('c102', '김길순', '010-1010-1002', 'p101');
INSERT INTO `child` VALUES ('c103', '장길동', '010-1010-1003', 'p103');

# parent에 참조하려는 p105가 없어서 오류뜬다
# INSERT INTO `child` VALUES ('c104', '홍길동', '010-1010-1003', 'p105');

# 실습하기 2-4
# 마땅히 구분할 키가 없을 때 `seq`로 설정
CREATE TABLE `user4` (
			`seq` INT AUTO_INCREMENT PRIMARY KEY,
			`name` VARCHAR(10),
			`gender` TINYINT,
			`age` INT,
			`addr` VARCHAR(255)
			);

INSERT INTO `user4` (`name`, `gender`, `age`, `addr`) VALUES ('김유신', 1, 25, '김해시');
INSERT INTO `user4` (`name`, `gender`, `age`, `addr`) VALUES ('김춘추', 1, 22, '경주시');
INSERT INTO `user4` (`name`, `gender`, `age`, `addr`) VALUES ('장보고', 1, 35, '완도시');
INSERT INTO `user4` (`name`, `gender`, `age`, `addr`) VALUES ('신사임당', 2, 42, '강릉시');
INSERT INTO `user4` (`name`, `gender`, `age`, `addr`) VALUES ('이순신', 1, 55, '서울시');
INSERT INTO `user4` SET `addr` = '부산시';



# 실습하기 2-5
# 초기값 설정과 null값 안받는 방법
CREATE TABLE `user5` (
			`seq` INT AUTO_INCREMENT PRIMARY KEY,
			`name` VARCHAR(10) NOT NULL,
			`gender` TINYINT DEFAULT 0,
			`age` INT DEFAULT 1,
			`addr` VARCHAR(255)
			);
			
INSERT INTO `user5` (`name`, `gender`, `age`, `addr`) VALUES ('김유신', 1, 25, '김해시');
INSERT INTO `user5` (`name`, `gender`, `age`, `addr`) VALUES ('김춘추', 1, 22, '경주시');
INSERT INTO `user5` (`name`, `gender`, `age`, `addr`) VALUES ('장보고', 1, 35, '완도시');
INSERT INTO `user5` (`name`, `gender`, `age`, `addr`) VALUES ('신사임당', 2, 42, '강릉시');
INSERT INTO `user5` (`name`, `gender`, `age`, `addr`) VALUES ('이순신', 1, 55, '서울시');
# `name` 은 null을 허용하지 않는데 null값이라 오류 뜬다
# INSERT INTO `user5` SET `addr` = '부산시';
INSERT INTO `user5` SET `name` = '송상현', `addr` = '부산시';

# 실습하기 2-6
# 복사하기 
CREATE TABLE `user6` LIKE `user5`;

# 실습하기 2-7
# 내용 옮기기
INSERT INTO `user6` SELECT * FROM `user5`;
INSERT INTO `user6` (`name`, `gender`, `age`, `addr`)
		SELECT `name`, `gender`, `age`, `addr` FROM `user5`;


