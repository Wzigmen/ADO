USE PD_318_DML;
GO

SELECT group_id AS 'ID',
	direction_name AS N'Направление обучения',
	group_name AS N'Название группы',					
	COUNT(student_id) AS N'Количество студентов'
FROM Students,Groups,Directions
WHERE direction=direction_id AND [group]=group_id
GROUP BY group_id,group_name,direction_name