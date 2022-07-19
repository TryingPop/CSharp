# 날짜 : 22.07.19
# 내용 : SQL 확인문제



# 실습하기 4-1
CREATE TABLE `tbl_member` (
		`컬럼명(한글)` VARCHAR(10),
		`영문명` VARCHAR(15),
		`데이터유형` VARCHAR(3),
		`길이` VARCHAR(2),
		`NULL허용` VARCHAR(1),
		`기본값` VARCHAR(2)
		);

INSERT INTO `tbl_member` VALUES ('아이디(PK)', 'memberID', '문자열', '10', 'X', '없음');
INSERT INTO `tbl_member` VALUES ('이름', 'memberName', '문자열', '10', 'X', '없음');
INSERT INTO `tbl_member` (`컬럼명(한글)`, `영문명`, `데이터유형`, `길이`, `NULL허용`) 
						VALUES ('휴대폰(UK)', 'memberHp', '문자열', '13', 'O');
INSERT INTO `tbl_member` (`컬럼명(한글)`, `영문명`, `데이터유형`, `길이`, `NULL허용`) 
						VALUES ('나이', 'memberAge', '숫자', '정수', 'O');						
INSERT INTO `tbl_member` (`컬럼명(한글)`, `영문명`, `데이터유형`, `길이`, `NULL허용`) 
						VALUES ('주소', 'memberAddr', '문자열', '20', 'O');					
						
CREATE TABLE `tbl_product` (
		`컬럼명(한글)` VARCHAR(10),
		`영문명` VARCHAR(15),
		`데이터유형` VARCHAR(8),
		`길이` VARCHAR(2),
		`NULL허용` VARCHAR(1),
		`기본값` VARCHAR(14)
		);


INSERT INTO `tbl_product` VALUES ('제품번호(PK)', 'productCode', '숫자', '정수', 'X', 'AUTO_INCREMENT');
INSERT INTO `tbl_product` VALUES ('제품명', 'productName', '문자열', '10', 'X', '없음');
INSERT INTO `tbl_product` VALUES ('가격', 'price', '숫자', '정수', 'X', '없음');
INSERT INTO `tbl_product` VALUES ('남은수량', 'amount', '숫자', '정수', 'X', '0');
INSERT INTO `tbl_product` (`컬럼명(한글)`, `영문명`, `데이터유형`, `길이`, `NULL허용`) 
						VALUES ('제조회사', 'company', '문자열', '10', 'O');		
INSERT INTO `tbl_product` (`컬럼명(한글)`, `영문명`, `데이터유형`, `길이`, `NULL허용`) 
						VALUES ('제조일자', 'makeDate', '날짜(년월일)', '날짜', 'O');					


DROP TABLE `tbl_member`;
DROP TABLE `tbl_product`;

# 실습하기 4-2
CREATE TABLE `tbl_member` (
			`memberID` VARCHAR(10) PRIMARY KEY,
			`memberName` VARCHAR(10) NOT NULL,
			`memberHp` VARCHAR(13) UNIQUE,
			`memberAge` INT,
			`memberAddr` VARCHAR(20));

CREATE TABLE `tbl_product` (
			`productCode` INT AUTO_INCREMENT PRIMARY KEY,
			`productName` VARCHAR(10) NOT NULL,
			`price` INT NOT NULL,
			`amount` INT DEFAULT 0,
			`company` VARCHAR(10),
			`makeDate` VARCHAR(10));

INSERT INTO `tbl_member` VALUES ('p101', '김유신', '010-1234-1001', 25, '신라');
INSERT INTO `tbl_member` VALUES ('p102', '김춘추', '010-1234-1002', 23, '신라');
INSERT INTO `tbl_member` (`memberID`, `memberName`, `memberAge`, `memberAddr`)
					VALUES ('p103', '장보고', 31, '통일신라');
INSERT INTO `tbl_member` (`memberID`, `memberName`, `memberAddr`)
					VALUES ('p104', '강감찬', '고려');
INSERT INTO `tbl_member` (`memberID`, `memberName`, `memberHp`, `memberAge`)
					VALUES ('p105', '이순신', '010-1234-1005', 50);
					

INSERT INTO `tbl_product` SET `productName` = '냉장고', `price` = 800, `amount` = 10, `company` = 'LG', `makeDate` = '2022-01-06';
INSERT INTO `tbl_product` SET `productName` = '노트북', `price` = 1200, `amount` = 20, `company` = '삼성', `makeDate` = '2022-01-06';
INSERT INTO `tbl_product` SET `productName` = 'TV', `price` = 1400, `amount` = 6, `company` = 'LG', `makeDate` = '2022-01-06';
INSERT INTO `tbl_product` SET `productName` = '세탁기', `price` = 1000, `amount` = 8, `company` = 'LG', `makeDate` = '2022-01-06';
INSERT INTO `tbl_product` SET `productName` = '컴퓨터', `price` = 1100, `amount` = 0;
INSERT INTO `tbl_product` SET `productName` = '휴대폰', `price` = 900, `amount` = 102, `company` = '삼성', `makeDate` = '2022-01-06';

# 실습하기 4-3
SELECT `memberName` FROM `tbl_member`;
SELECT `memberName`, `memberHp` FROM `tbl_member`;
SELECT * FROM `tbl_member` WHERE `memberID` = 'p102';
SELECT * FROM `tbl_member` WHERE `memberID` = 'p104' OR `memberID` = 'p105';
SELECT * FROM `tbl_member` WHERE `memberAddr` = '신라';
SELECT * FROM `tbl_member` WHERE `memberAge` > 30;
SELECT * FROM `tbl_member` WHERE `memberHp` IS NULL;
UPDATE `tbl_member` SET `memberAge` = 42 WHERE `memberID` = 'p104';
UPDATE `tbl_member` SET `memberAddr` = '조선' WHERE `memberID` = 'p105';
DELETE FROM `tbl_member` WHERE `memberID` = 'p103';
SELECT * FROM `tbl_member`;

SELECT `productName` FROM `tbl_product`;
SELECT `productName`, `price` FROM `tbl_product`;
SELECT * FROM `tbl_product` WHERE `company` = '삼성';
UPDATE `tbl_product` SET `company` = '삼성', `makeDate` = '2021-01-01'
							WHERE `productCode` = 5;
SELECT * FROM `tbl_product`;							