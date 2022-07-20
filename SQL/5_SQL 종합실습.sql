# 날짜 : 22.07.20
# 내용 : SQL 종합실습

# 실습하기 5-1
CREATE DATABASE `saledb`;
CREATE USER 'manager'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON `saledb`.* TO 'manager'@'%';
FLUSH PRIVILEGES;

# 실습하기 5-2
CREATE TABLE `Member` (
			`uid` VARCHAR(10) PRIMARY KEY,
			`name` VARCHAR(10) NOT NULL,
			`hp` CHAR(13) NOT NULL,
			`pos` VARCHAR(10) DEFAULT '사원',
			`dep` TINYINT,
			`rdate` DATETIME NOT NULL
			);

CREATE TABLE `Department`(
			`depNo` INT PRIMARY KEY,
			`name` VARCHAR(10) NOT NULL,
			`tel` CHAR(12)
			);

CREATE TABLE `Sales`(
			`seq` INT AUTO_INCREMENT PRIMARY KEY,
			`uid` VARCHAR(10) NOT NULL,
			`year` YEAR NOT NULL,
			`month` TINYINT NOT NULL,
			`sale` INT NOT NULL
			);
			
DROP TABLE `department`, `member`, `sales`;
# 실습하기 5-3
INSERT INTO `Member` VALUES ('a101', '박혁거세', '010-1234-1001', '부장', 101, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a102', '김유신', '010-1234-1002', '차장', 101, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a103', '김춘추', '010-1234-1003', '사원', 101, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a104', '장보고', '010-1234-1004', '대리', 102, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a105', '강감찬', '010-1234-1005', '과장', 102, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a106', '이성계', '010-1234-1006', '차장', 103, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a107', '정철', '010-1234-1007', '차장', 103, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a108', '이순신', '010-1234-1008', '부장', 104, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a109', '허균', '010-1234-1009', '부장', 104, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a110', '정약용', '010-1234-1010', '사원', 105, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a111', '박지원', '010-1234-1011', '사원', 105, '2020-11-19 11:39:48');


INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a101', 2018, 1, 98100);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2018, 1, 136000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2018, 1, 80100);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2018, 1, 78000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2018, 1, 93000);

INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a101', 2018, 2, 23500);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2018, 2, 126000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2018, 2, 18500);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2018, 2, 19000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a106', 2018, 2, 53000);

INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a101', 2019, 1, 24000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2019, 1, 109000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2019, 1, 101000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2019, 1, 53500);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a107', 2019, 1, 24000);

INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2019, 2, 160000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2019, 2, 101000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2019, 2, 43000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2019, 2, 24000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a106', 2019, 2, 109000);

INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2020, 1, 201000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2020, 1, 63000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2020, 1, 74000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2020, 1, 122000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a106', 2020, 1, 111000);

INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2020, 2, 120000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2020, 2, 93000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2020, 2, 84000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2020, 2, 180000);
INSERT INTO `sales` (`uid`, `year`, `month`, `sale`) VALUES ('a108', 2020, 2, 76000);


INSERT INTO `department` (`depNo`, `name`, `tel`) VALUES (101,'영업1부', '051-512-1001');
INSERT INTO `department` (`depNo`, `name`, `tel`) VALUES (102,'영업2부', '051-512-1002');
INSERT INTO `department` (`depNo`, `name`, `tel`) VALUES (103, '영업3부', '051-512-1003');
INSERT INTO `department` (`depNo`, `name`, `tel`) VALUES (104, '영업4부', '051-512-1004');
INSERT INTO `department` (`depNo`, `name`, `tel`) VALUES (105, '영업5부', '051-512-1005');
INSERT INTO `department` (`depNo`, `name`, `tel`) VALUES (106, '영업지원부', '051-512-1006');
INSERT INTO `department` (`depNo`, `name`, `tel`) VALUES (107, '인사부', '051-512-1007');

# 실습하기 5-4
SELECT * FROM `member` WHERE `name` = '김유신';

SELECT * FROM `member` WHERE `pos` = '차장' AND `dep` = 101;
SELECT * FROM `member` WHERE `pos` = '차장' OR  `dep` = 101;

# <>와 같은 표현
SELECT * FROM `member` WHERE `name` != '김춘추';
SELECT * FROM `member` WHERE `name` <> '김춘추';

# IN은 내장함수로서 아래와 같다
SELECT * FROM `member` WHERE `pos` = '사원' OR pos = '대리';
SELECT * FROM `member` WHERE `pos` IN('사원', '대리');

SELECT * FROM `member` WHERE `dep` IN(101, 102, 103);

# % 에 무엇이 오던 상관없다
SELECT * FROM `member` WHERE `name` LIKE '%신';
SELECT * FROM `member` WHERE `name` LIKE '김%';

# _ 뒤에 1글자 아무거나 와도 상관없다
SELECT * FROM `member` WHERE `name` LIKE '김__';
SELECT * FROM `member` WHERE `name` LIKE '_성_';
SELECT * FROM `member` WHERE `name` LIKE '정_';

SELECT * FROM `sales` WHERE `sale` > 50000;
SELECT * FROM `sales` WHERE `sale` >= 50000 AND `sale` < 100000 AND `month` = 1;
SELECT * FROM `sales` WHERE `sale` BETWEEN 50000 AND 100000;
SELECT * FROM `sales` WHERE `sale` NOT BETWEEN 50000 AND 100000;
SELECT * FROM `sales` WHERE `year` IN(2020);
SELECT * FROM `sales` WHERE `month` IN(1,2);



# 실습하기 5-5
SELECT * FROM `sales` ORDER BY `sale`;
SELECT * FROM `sales` ORDER BY `sale` ASC;
SELECT * FROM `sales` ORDER BY `sale` DESC;
SELECT * FROM `member` ORDER BY `name`;
SELECT * FROM `member` ORDER BY `rdate` ASC;
SELECT * FROM `sales` WHERE `sale` > 50000 ORDER BY `sale` DESC;
SELECT * FROM `sales` WHERE `sale` > 50000 ORDER BY `year`, `month`, `sale` DESC;

# 실습하기 5-6
SELECT * FROM `sales` LIMIT 3;
SELECT * FROM `sales` LIMIT 0, 3;
SELECT * FROM `sales` LIMIT 1, 3;
SELECT * FROM `sales` LIMIT 4, 5;

SELECT * FROM `sales` ORDER BY `sale` DESC LIMIT 3, 5;
SELECT * FROM `sales` WHERE `sale` < 50000 ORDER BY `sale` DESC LIMIT 3;
SELECT * FROM `sales` WHERE `sale` > 50000 ORDER BY `year` DESC, `month`, `sale` DESC LIMIT 5;

# 실습하기 5-7
SELECT SUM(`sale`) AS `합계` FROM `sales`;
SELECT AVG(`sale`) AS `평균` FROM `sales`;
SELECT MAX(`sale`) AS `최대값` FROM `sales`;
SELECT MIN(`sale`) AS `최소값` FROM `sales`;
SELECT COUNT(`sale`) AS `갯수` FROM `sales`;
SELECT COUNT(*) AS `갯수` FROM `sales`;
SELECT SUBSTRING(hp, 10, 4) AS '전화번호 끝자리' FROM `member`;

INSERT INTO `member` VALUES ('b101', '을지문덕', '010-5555-1234', '사장', 107, NOW());

# 확인문제
SELECT SUM(`sale`) AS `매출의 총합` FROM `sales` WHERE `year` = 2018 AND `month` = 1;
SELECT 
		SUM(`sale`)  AS `매출의 총합`, 
		AVG(`sale`) AS `매출의 평균` 
	FROM 
		`sales` 
	WHERE 
		`YEAR` = 2019 AND `month` = 2 AND `sale` >= 50000;
SELECT 
		MIN(`sale`) AS `매출의 최저`, 
		MAX(`sale`) AS `매출의 최고` 
	FROM `sales` 
	WHERE `year` IN(2020);


# 실습하기 5-8
SELECT * FROM `sales` GROUP BY `uid`;
SELECT * FROM `sales` GROUP BY `year`;
SELECT * FROM `sales` GROUP BY `uid`, `year`;
SELECT `uid`, COUNT(*) AS `건수` FROM `sales` Group by `uid`;
SELECT `uid`, SUM(`sale`) AS `합계` FROM `sales` Group by `uid`;
SELECT `uid`, AVG(`sale`) AS `평균` FROM `sales` Group by `uid`;

SELECT `uid`, `year`, SUM(sale) AS `합계` FROM `sales` GROUP BY `uid`, `year`;
SELECT `uid`, `year`, SUM(sale) AS `합계` FROM `sales` GROUP BY `uid`, `year` ORDER BY `year` ASC, `합계` DESC;
SELECT `uid`, `year`, SUM(sale) AS `합계` FROM `sales` WHERE `sale` >= 50000 GROUP BY `uid`, `year` ORDER BY `합계` DESC;


# 실습하기 5-9
# SELECT `uid`, SUM(`sale`) AS `합계` FROM `sales` GROUP BY `uid` HAVING `합계` >= 200000;
SELECT `uid`, SUM(`sale`) AS `합계` FROM `sales` GROUP BY `uid` HAVING SUM(sale) >= 200000;
SELECT `uid`, `year`, SUM(sale) AS `합계` FROM `sales` WHERE `sale` >= 100000 GROUP BY `uid`, `year` HAVING SUM(sale) >= 200000 ORDER BY `합계` DESC;


# 실습하기 5-10

# `sales2`를 `sales`의 목차를 참고해서 생성
CREATE TABLE `sales2` LIKE `sales`;
# `sales2`에 `sales` 원소를 넣기
INSERT INTO `sales2` SELECT * FROM `sales`;
# `sales2`의 년도의 값을 각각 3년씩 증가
UPDATE `sales2` SET `year` = `year` + 3;

# 행을 이어 붙이는거
SELECT * FROM `sales` UNION SELECT * FROM `sales2`;
# 컬럼 갯수와 이름이 같아야 행 이어붙이기 가능
(SELECT * FROM `sales`) UNION (SELECT * FROM `sales`);
SELECT `uid`, `year`, `sale` FROM `sales` UNION SELECT `uid`, `year`, `sale` FROM `sales2`;

SELECT `uid`, `year`, SUM(`sale`) AS `합계` FROM `sales2` GROUP BY `uid`, `year` ORDER BY `year` ASC, `합계` DESC;

# 실습하기 5-11
# seq의 중복 값 때문에 위에껀 유니온 안된다
SELECT `seq`, `uid`, `sale` FROM `sales` UNION SELECT `seq`, `uid`, `sale` FROM `sales2`;
# 반면 all을 씀으로써 유니온 가능
SELECT `seq`, `uid`, `sale` FROM `sales` UNION ALL SELECT `seq`, `uid`, `sale` FROM `sales2`;

# 실습하기 5-12
SELECT * FROM `sales` INNER JOIN `member` ON `sales`.`uid` = `member`.`uid`;
SELECT sales.`seq`, sales.`year`, sales.`month`, sales.`uid`, `name`, `pos`, `sale` FROM `sales` JOIN `member` ON sales.uid = member.uid;
SELECT a.`seq`, a.`uid`, `sale`, `name`, `pos` FROM `sales` AS a JOIN `member` AS b ON a.`uid` = b.`uid`;
SELECT `a`.`seq`, `a`.`uid`, `sale`, `name`, `pos` FROM `sales` AS a JOIN `member` AS b USING(`uid`);
SELECT a.`seq`, a.`uid`, `sale`, `name`, `pos` FROM `sales` AS a JOIN `member` AS b USING(uid) WHERE `sale` >= 100000;
SELECT a.`seq`, a.`uid`, b.`name`, b.`pos`, `year`, SUM(`sale`) AS `합계` FROM `sales` AS a 
	JOIN 
	`member` AS b 
	ON a.uid = b.uid 
	GROUP BY a.`uid`, a.`year` 
	HAVING `합계` >= 100000 
	ORDER BY a.`year` ASC, `합계` DESC;
SELECT * FROM `sales` AS a JOIN `member` AS b ON a.uid = b.uid
JOIN `department` AS c ON b.dep = c.depNo;

SELECT a.seq, a.uid, a.sale, b.name, b.pos, c.`name` FROM `sales` AS a JOIN `member` AS b USING(uid) JOIN `department` AS c ON b.dep = c.depNo
WHERE `sale` > 100000 ORDER BY `sale` DESC;


SELECT * FROM `sales` AS a 
	JOIN `member` as b 
# a.uid와 b.uid에 맞춰서 결합
	on a.uid = b.uid;
	
SELECT a.`seq`, a.`uid`, `sale`, `NAME`, `pos` FROM `sales` AS a JOIN `member` AS b ON USING(`uid`);

SELECT * FROM `sales` AS a JOIN `member` AS b ON a.`uid` = b.`uid` JOIN `department` AS c ON b.`dep` = c.`depNo`;


# 실습하기 5-13
SELECT * FROM `sales` LEFT JOIN `member` ON `sales`.uid = `member`.uid;
SELECT * FROM `sales` RIGHT JOIN `member` ON `sales`.uid = `member`.uid;

SELECT a.seq, a.uid, `sale`, `name`, `pos` FROM sales AS a LEFT JOIN member AS b ON USING(uid);
SELECT a.seq, a.uid, `sale`, `name`, `pos` FROM sales AS a RIGHT JOIN member AS b ON USING(uid);

# 확인문제
SELECT a.uid, a.`name`, a.pos, b.`name` FROM `member` AS a LEFT JOIN `department` AS b ON a.dep = b.depNo;

SELECT SUM(b.`sale`) AS `김유신 직원의 2019년도 매출` 
		FROM `sales` AS b 
		JOIN `member` AS a 
		ON a.`uid` = b.`uid` 
		WHERE a.`name` = '김유신' AND `year` = 2019;
		
SELECT a.`name`, c.`name`, a.`pos`, b.`year`, SUM(b.`sale`) AS `매출합` FROM `member` AS a
	LEFT JOIN `sales` AS b
	ON a.uid = b.uid
	LEFT JOIN `department` AS c
	ON a.dep = c.depNo
	WHERE b.`year` = 2019 AND b.`sale` >= 50000
	GROUP BY a.uid
	HAVING `매출합` >= 100000
	ORDER BY `매출합` DESC;