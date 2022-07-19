# 날짜 : 22.07.19
# 내용 : 데이터베이스 관리

# 실습하기 3-1
# 데이터 베이스 만들기
# CREATE DATABASE `tigerdb`;
# tiger 라는 계정 만들기 % 원격지에서 접속
# mysql에서 user 테이블에서 확인가능
CREATE USER 'tiger'@'%' IDENTIFIED BY '1234';

# tiger계정한테 tigerdb한테 모든 권한을 주는거
GRANT ALL PRIVILEGES ON tigerdb.* TO 'tiger'@'%';
# 주는거
FLUSH PRIVILEGES;


# 실습하기 3-2
# 비밀번호 변경
SET PASSWORD FOR 'tiger'@'%'=PASSWORD('12345');
# 계정 삭제
# root계정만 가능
DROP USER 'tiger'@'%';
FLUSH PRIVILEGES;

# 실습하기 3-3
# userdb 백업
CREATE DATABASE `userdb`;