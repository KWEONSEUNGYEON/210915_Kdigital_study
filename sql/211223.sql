CREATE TABLE member (
	`email` VARCHAR(50) NULL DEFAULT NULL,
	`pwd` VARCHAR(50) NULL DEFAULT NULL,
	`gender` VARCHAR(50) NULL DEFAULT NULL
)
COLLATE='utf8_general_ci'aamember
;


INSERT INTO `aa`.`member` 
(`email`, `pwd`, `gender`)
VALUES 
('dron512@naver.com', '1234', '남');
INSERT INTO `aa`.`member` (`email`, `pwd`, `gender`) VALUES ('aa@naver.com', '5678', '여');


SELECT * FROM member;
