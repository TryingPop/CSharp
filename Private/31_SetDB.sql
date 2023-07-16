# database 삭제
userdbDROP DATABASE `userdb`;

# database 생성
CREATE DATABASE `userdb`;

# 테이블 생성
# 앞에서 만든 userdb 데이터베이스를 사용
USE `userdb`;
# uid, name, ip 를 정보를 갖는 user 테이블 생성
CREATE TABLE `user` (
	`name`		VARCHAR(10),
	`ip`		CHAR(15),
	);
	
