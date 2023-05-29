select * from person
select * from car
select a.Name from car a
INNER JOIN Connection b ON a.CarId = b.CarId2
WHERE b.PersonId2 = 1;
