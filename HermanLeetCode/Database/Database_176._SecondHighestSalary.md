# SQL架构
	Write a SQL query to get the second highest salary from the Employee table.

		+----+--------+
		| Id | Salary |
		+----+--------+
		| 1  | 100    |
		| 2  | 200    |
		| 3  | 300    |
		+----+--------+
	For example, given the above Employee table, the query should return 200 as the second highest salary. If there is no second highest salary, then the query should return null.

		+---------------------+
		| SecondHighestSalary |
		+---------------------+
		| 200                 |
		+---------------------+
# 题目大意

	从员工表中提取薪水第二高的薪水

# sql实现
	
	SELECT MAX(e1.Salary) SecondHighestSalary
	FROM Employee e1
	WHERE e1.Salary != (SELECT MAX(e2.Salary) FROM Employee e2);
