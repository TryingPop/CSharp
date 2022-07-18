# 날짜 : 22.07.18
# 내용 : 교재 2장 테이블에서 데이터 검색

# 4강 Hello World 실행하기
CREATE TABLE `sample21` (
	`no` 			INT,
	`name` 		VARCHAR(10),
	`birthday` 	CHAR(10),
	`address` 	VARCHAR(100)
	);
# userdb

# 데이터 저장
INSERT INTO `sample21` 
						VALUES (1, 
								  '박준용', 
		  						  '1976-10-18',
								  '대구광역시 수성구'
								 );
								
INSERT INTO `sample21` (`no`, `name`, `address`)
						VALUES (2, '김재진', '대구광역시 동구');
INSERT INTO `sample21` SET `no` = 3, 
									`name` = '홍길동',
									`address` = '서울특별시 마포구';

# p53
SELECT * FROM `sample21`;

# 5강 테이블 구조 참조하기
# p62
# 열이 어떻게 정의되어있는지 확인
DESC `sample21`;

# 6강 검색조건 지정하기
# p66
SELECT * FROM `sample21`;
# 필요한 열만 가져오기
SELECT `no`, `name` FROM `sample21`;

# p68 
SELECT * FROM `sample21`;
# 조건에 맞는 행 가져오기
SELECT * FROM `sample21` WHERE `no` = 2;

# p70
SELECT * FROM `sample21`;
# where로 no 값이 2가 아닌 행 추출
# 서로 다른 값을 나타내는 건 <> 
SELECT * FROM `sample21` WHERE `no` <> 2;

# p71 
SELECT * FROM `sample21`;
# name 열 값이 박준용인 행만 추출
SELECT * FROM `sample21` WHERE `name` = '박준용';

# p72
SELECT * FROM `sample21`;
# Null값 추출하기
# = 로는 Null 값 추출 불가능
SELECT * FROM `sample21` WHERE `birthday` = NULL;

# p73
SELECT * FROM `sample21`;
# is Null 문법으로 Null값 추출 가능
SELECT * FROM `sample21` WHERE `birthday` IS NULL;

# 7강 조건 조합하기
CREATE TABLE `sample24`(
`no` INT, 
`a` INT,
`b` INT,
`c` INT
);

INSERT INTO `sample24` VALUES (1, 1 , 0, 0);
INSERT INTO `sample24` (`no`, `a`, `c`, `b`) 
						VALUES (2, 0 , 0, 1);
INSERT INTO `sample24` SET `no` = 3, `a` = 0, `b` = 0, `c` = 1;
INSERT INTO `sample24` VALUES (4, 2, 2, 0);
INSERT INTO `sample24` VALUES (5, 0, 2, 2);

# p76
SELECT * FROM `sample24`;
# and 연산자로 조건식 조합하기
SELECT * FROM `sample24` WHERE a <>0 AND b <> 0;

# p78
SELECT * FROM `sample24`;
# or 연산자로 조건식 조합하기
SELECT * FROM `sample24` WHERE a <>0 OR b <> 0;

# p80
SELECT * FROM `sample24`;
# or연산자와 and 연산자 조합하기
SELECT * FROM sample24 WHERE a=1 OR a=2 AND b=1 OR b=2;
# or보다 and의 연산 우선순위가 높다
# 결과적으로 a = 1 or (a = 2 and b = 1) or b = 2

# p82
SELECT * FROM `sample24`;
# not 연산자
SELECT * FROM `sample24` WHERE NOT (a<>0 OR b<>0);


# 8강 패턴 매칭에 의한 검색
CREATE TABLE `sample25`(
`no` INT,
`text` VARCHAR(255)
);

INSERT INTO `sample25` SET `text` = 'SQL은 RDBMS를 조작하는 언어이다', `no` = 1;
INSERT INTO `sample25` SET `text` = 'LIKE에서는 메타문자 %와 _를 사용할 수 있다', `no` = 2;
INSERT INTO `sample25` SET `text` = 'LIKE는 SQL에서 사용할 수 있는 술어 중 하나이다', `no` = 3;

# p85
SELECT * FROM `sample25`;
# SQL을 포함하는 행을 검색
# where + 찾을장소 + like 찾을 문자 + %
# 1번만 검색된다
SELECT * FROM `sample25` WHERE `text` LIKE 'sql%';

# p86
SELECT * FROM `sample25`;
# 중간에 일치하는 문자 찾기
SELECT * FROM `sample25` WHERE `text` LIKE '%sql%';
# 1번 3번 검색
# %는 임의의 문자열과 빈문자에 매칭된다

# p88 
SELECT * FROM `sample25`;
# %를 포함하는 행 검색
SELECT * FROM `sample25` WHERE `text` LIKE '%\%%';