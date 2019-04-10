USE contracted1;

/* CREATE TABLE contractors (
  id VARCHAR(255) NOT NULL,
  name VARCHAR(255) NOT NULL,
  rate DECIMAL(5,2) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE jobs (
  id INT AUTO_INCREMENT,
  title VARCHAR(255),
  location VARCHAR(255),
  budget DECIMAL(10, 2),
  PRIMARY KEY (id)
); */

/* CREATE TABLE contractorJobs (
  id INT AUTO_INCREMENT,
  contractorId VARCHAR(255),
  jobId INT NOT NULL,
  PRIMARY KEY (id),
  INDEX (jobId),

  FOREIGN KEY (contractorId) 
      REFERENCES contractors(id)
      ON DELETE CASCADE,

  FOREIGN KEY (jobId) 
      REFERENCES jobs(id)
      ON DELETE CASCADE
); */


/* INSERT INTO contractors (id, name, rate)
    VALUES ("3h234n", "DMoney", 100.50), ("23lee3", "Jake", 25.88), ("2s3jj9", "Mark", 3.00);

INSERT INTO jobs (title, location, budget)
    VALUES ("BCW Expansion", "123 Capital Blv", 100000.4),
            ("BOA", "1234 Fake St", 1000),
            ("Jamie's Buger Den", "568 Poison ave", 100); */

/* INSERT INTO contractorjobs (contractorId, jobId)
    VALUES ("3h234n", 1), ("23lee3", 1), ("2s3jj9", 3), ("23lee3", 2) */

    /* SELECT * FROM contractorjobs cj
    INNER JOIN contractors c ON c.id = cj.contractorId
    WHERE jobId = 1; */