CREATE TABLE IF NOT EXISTS product(
    Id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    Name VARCHAR(255) NOT NULL,
    Description TEXT,
    Price DECIMAL(10, 2) NOT NULL,
    brand_id UUID NOT NULL,
    product_type_id UUID NOT NULL,
    FOREIGN KEY (brand_id) REFERENCES brand(Id),
    FOREIGN KEY (product_type_id) REFERENCES product_type(Id)
);