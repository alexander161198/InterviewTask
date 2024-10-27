--Пусть есть 3 таблицы: product(id, name, ...), category(id, name, ...), product_category(id, product_id, category_id)

SELECT p."name", c."name" 
FROM product p
LEFT JOIN product_category pc on p.id = pc.product_id 
LEFT JOIN category c on c.id = pc.category_id 