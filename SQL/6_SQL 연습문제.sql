# 날짜 : 22.07.21
# 내용 : SQL 연습문제

# 실습하기 6-1
CREATE DATABASE `orderdb`;
CREATE USER 'master'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON `orderdb`.* TO 'master'@'%';
FLUSH PRIVILEGES;

# 실습하기 6-2
CREATE TABLE `customer` (
			`custId` VARCHAR(10) PRIMARY KEY,
			`name` VARCHAR(10) NOT NULL,
			`hp` VARCHAR(13),
			`addr` VARCHAR(100),
			`rdate` DATE NOT NULL
			);
			
CREATE TABLE `product` (
			`prodNo` INT AUTO_INCREMENT PRIMARY KEY,
			`prodName` VARCHAR(10) NOT NULL,
			`stock` INT DEFAULT 0,
			`price` INT,
			`company` VARCHAR(20) NOT NULL);
			
CREATE TABLE `order` (
			`orderNo` INT AUTO_INCREMENT PRIMARY KEY,
			`orderId` VARCHAR(10) NOT NULL,
			`orderProduct` INT NOT NULL,
			`orderCount` INT DEFAULT 1,
			`orderDate` DATETIME NOT NULL);



# 실습하기 6-3
INSERT INTO `customer` (`custId`, `name`, `rdate`) VALUES ('heoj', '허준', '2022-01-07');
INSERT INTO `customer` VALUES ('jang', '장보고', '010-1234-1003', '완도군 청산면', '2022-01-03');
INSERT INTO `customer` VALUES ('jeongc', '정철', '010-1234-1006', '경기도 용인시', '2022-01-06');
INSERT INTO `customer` VALUES ('jeongyy', '정약용', '010-1234-1010', '경기도 광주시', '2022-01-10');
INSERT INTO `customer` VALUES ('kang', '강감찬', '010-1234-1004', '서울시 마포구', '2022-01-04');
INSERT INTO `customer` VALUES ('kimcc', '김춘추', '010-1234-1002', '경주시 보문동', '2022-01-02');
INSERT INTO `customer` VALUES ('kimys', '김유신', '010-1234-1001', '김해시 봉활동', '2022-01-01');
INSERT INTO `customer` (`custId`, `name`, `rdate`) VALUES ('leesg', '이성계', '2022-01-05');
INSERT INTO `customer` VALUES ('leess', '이순신', '010-1234-1008', '서울시 영등포구', '2022-01-08');
INSERT INTO `customer` VALUES ('songsh', '송상현', '010-1234-1009', '부산시 동래구', '2022-01-09');

INSERT INTO `order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kimcc', 3, 2, '2022-07-01 13:15:10');
INSERT INTO `order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kimys', 4, 1, '2022-07-01 14:16:11');
INSERT INTO `order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('leess', 1, 1, '2022-07-01 17:23:18');
INSERT INTO `order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('songsh', 6, 5, '2022-07-02 10:46:36');
INSERT INTO `order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kimcc', 2, 1, '2022-07-03 09:15:37');

INSERT INTO `order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kimys', 7, 3, '2022-07-03 12:35:12');
INSERT INTO `order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('jeongyy', 1, 2, '2022-07-03 16:55:36');
INSERT INTO `order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kang', 2, 4, '2022-07-04 14:23:23');
INSERT INTO `order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('kimcc', 1, 3, '2022-07-04 21:54:34');
INSERT INTO `order` (`orderId`, `orderProduct`, `orderCount`, `orderDate`) VALUES ('heoj', 6, 1, '2022-07-05 14:21:03');


INSERT INTO `product` (`prodName`, `stock`, `price`, `company`) VALUES ('새우깡', 5000, 1500, '농심');
INSERT INTO `product` (`prodName`, `stock`, `price`, `company`) VALUES ('초코파이', 2500, 2500, '오리온');
INSERT INTO `product` (`prodName`, `stock`, `price`, `company`) VALUES ('포카칩', 3600, 1700, '오리온');
INSERT INTO `product` (`prodName`, `stock`, `price`, `company`) VALUES ('양파링', 1250, 1800, '농심');
INSERT INTO `product` (`prodName`, `stock`, `company`) VALUES ('죠리퐁', 2200, '크라운');
INSERT INTO `product` (`prodName`, `stock`, `price`, `company`) VALUES ('마카렛트', 3500, 3500, '롯데');
INSERT INTO `product` (`prodName`, `stock`, `price`, `company`) VALUES ('뿌셔뿌셔', 1650, 1200, '오뚜기');


# 실습하기 6-4
SELECT * FROM `customer`;


# 실습하기 6-5
SELECT `custid`, `name`, `hp` FROM `customer`;

# 실습하기 6-6
SELECT * FROM `product`;

# 실습하기 6-7
SELECT `company` FROM `product`;

# 실습하기 6-8
SELECT DISTINCT `company` FROM `product`;

# 실습하기 6-9
SELECT `prodName`, `price` FROM `product`;

# 실습하기 6-10
SELECT `prodname`, `price` +500 AS `조정단가` FROM `product`;

# 실습하기 6-11
SELECT `prodName`, `stock`, `price` FROM `product` WHERE `company` = '오리온';

# 실습하기 6-12
SELECT `orderproduct`, `orderCount`, `orderDate` FROM `order` WHERE `orderId` = 'kimcc';

# 실습하기 6-13
SELECT `orderProduct`, `orderCount`, `orderDate` FROM `order` WHERE `orderId` = 'kimcc' AND `orderCount` >= 2;

# 실습하기 6-14
SELECT * FROM `product` WHERE price >= 1000 AND price <= 2000;

# 실습하기 6-15
SELECT `custId`, `name`, `hp`, `addr` FROM `customer` WHERE `name` LIKE '김%';

# 실습하기 6-16
SELECT `custid`, `name`, `hp`, `addr` FROM `customer` WHERE `custid` LIKE '____';

# 실습하기 6-17
SELECT * FROM `customer` WHERE `hp` IS NULL;

# 실습하기 6-18
SELECT * FROM `customer` WHERE `addr` IS NOT NULL;

# 실습하기 6-19
SELECT * FROM `customer` ORDER BY `rdate` DESC; 

# 실습하기 6-20
SELECT * FROM `order` WHERE `ordercount` >= 3 order BY `orderCount` DESC, `orderProduct` ASC;

# 실습하기 6-21
SELECT AVG(`price`) FROM `product`;

# 실습하기 6-22
SELECT SUM(`stock`) AS `재고량 합계` FROM `product` WHERE `company` = '농심';

# 실습하기 6-23
SELECT COUNT(`custid`) AS `고객수` FROM `customer`;

# 실습하기 6-24
SELECT COUNT(DISTINCT `company`) AS `제조업체 수` FROM `product`;


# 실습하기 6-25
SELECT `orderProduct` AS `주문 상품번호`,  SUM(`ordercount`) AS `총 주문수량` FROM `order` GROUP BY `orderproduct`;

# 실습하기 6-26
SELECT `company` AS `제조업체`, COUNT(*) AS `제품수`, MAX(`price`) AS `최고가` FROM `product` GROUP BY `company`;

# 실습하기 6-27
SELECT `company` AS `제조업체`, COUNT(*) AS `제품수`, MAX(`price`) AS `최고가` FROM `product` GROUP BY `company` HAVING `제품수` >= 2 AND MAX(`price`);

# 실습하기 6-28
SELECT `orderproduct`, `orderId`, SUM(`orderCount`) AS `총 주문수량` FROM `order` GROUP BY `orderno`  order BY `orderproduct` ASC;

# 실습하기 6-29
SELECT a.orderId, b.prodname FROM `order` AS a JOIN `product` AS b ON a.orderproduct = b.prodno WHERE `orderid` = 'kimcc';

# 실습하기 6-30
SELECT `orderid`, `name`, `prodname`, `orderdate` FROM `order` AS a JOIN `customer` AS b ON a.orderid = b.custId JOIN `product` AS c
		ON a.orderProduct = c.prodNo WHERE LEft(a.orderdate, 10) = '2022-07-03';
