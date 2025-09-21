INSERT INTO products(Name, Description, Price, brand_id, product_type_id) VALUES
('iPhone 13', 'Latest Apple smartphone with advanced features.', 999.99, (SELECT Id FROM brands WHERE Name = 'Apple'), (SELECT Id FROM product_types WHERE Name = 'Electronics')),
('Galaxy S21', 'Flagship Samsung smartphone with high-end specs.', 799.99, (SELECT Id FROM brands WHERE Name = 'Samsung'), (SELECT Id FROM product_types WHERE Name = 'Electronics')),
('Air Jordan 1', 'Iconic Nike basketball shoes with classic design.', 150.00, (SELECT Id FROM brands WHERE Name = 'Nike'), (SELECT Id FROM product_types WHERE Name = 'Clothing')),
('Ultraboost Shoes', 'Comfortable Adidas running shoes with Boost technology.', 180.00, (SELECT Id FROM brands WHERE Name = 'Adidas'), (SELECT Id FROM product_types WHERE Name = 'Clothing')),
('PlayStation 5', 'Next-gen Sony gaming console with immersive graphics.', 499.99, (SELECT Id FROM brands WHERE Name = 'Sony'), (SELECT Id FROM product_types WHERE Name = 'Electronics')),
('MacBook Pro', 'High-performance laptop from Apple for professionals.', 1299.99, (SELECT Id FROM brands WHERE Name = 'Apple'), (SELECT Id FROM product_types WHERE Name = 'Electronics')),
('Galaxy Tab S7', 'Versatile Samsung tablet for work and play.', 649.99, (SELECT Id FROM brands WHERE Name = 'Samsung'), (SELECT Id FROM product_types WHERE Name = 'Electronics')),
('Nike Dri-FIT Shirt', 'Breathable sports shirt from Nike for active wear.', 35.00, (SELECT Id FROM brands WHERE Name = 'Nike'), (SELECT Id FROM product_types WHERE Name = 'Clothing')),
('Adidas Soccer Ball', 'Official size and weight soccer ball from Adidas.', 30.00, (SELECT Id FROM brands WHERE Name = 'Adidas'), (SELECT Id FROM product_types WHERE Name = 'Toys')),
('Sony WH-1000XM4', 'Noise-cancelling wireless headphones from Sony.', 349.99, (SELECT Id FROM brands WHERE Name = 'Sony'), (SELECT Id FROM product_types WHERE Name = 'Electronics'));