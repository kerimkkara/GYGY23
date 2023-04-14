

CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name NVARCHAR(50)
);

CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name NVARCHAR(100),
    description NVARCHAR(500),
    category_id INT,
    price MONEY,
    stock_quantity INT,
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);



CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    user_id INT,
    order_date DATETIME,
    total_price MONEY,
    FOREIGN KEY (user_id) REFERENCES users(user_id)
);

CREATE TABLE order_details (
    order_detail_id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT,
    unit_price MONEY,
    FOREIGN KEY (order_id) REFERENCES orders(order_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

CREATE TABLE addresses (
    address_id INT PRIMARY KEY,
    user_id INT,
    address_type NVARCHAR(50),
    address_line_1 NVARCHAR(100),
    address_line_2 NVARCHAR(100),
    city NVARCHAR(50),
    state NVARCHAR(50),
    zip_code NVARCHAR(20),
    FOREIGN KEY (user_id) REFERENCES users(user_id)
);

CREATE TABLE payment_info (
    payment_info_id INT PRIMARY KEY,
    user_id INT,
    cardholder_name NVARCHAR(100),
    card_number NVARCHAR(50),
    expiration_date NVARCHAR(10),
    security_code NVARCHAR(10),
    FOREIGN KEY (user_id) REFERENCES users(user_id)
);
