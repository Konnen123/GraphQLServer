﻿CREATE TABLE IF NOT EXISTS product_types(
    Id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    Name VARCHAR(255) NOT NULL,
    Description TEXT
);