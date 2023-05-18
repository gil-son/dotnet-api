# dotnet-api



postgreSQL

```

CREATE TABLE IF NOT EXISTS tb_person (
    "c_id_person" SERIAL PRIMARY KEY,
    "c_name" VARCHAR(100),
    "c_document" VARCHAR(20),
    "c_celphone" VARCHAR(20)
   
);


CREATE TABLE IF NOT EXISTS tb_product (
    "c_id_product" SERIAL PRIMARY KEY,
    "c_name" character varying(100),
    "c_coderp" character varying(10),
    "c_price" numeric(10,2)
    
);


CREATE TABLE IF NOT EXISTS tb_purchase (
    "c_id_purchase" SERIAL PRIMARY KEY,
    "c_id_product" integer,
    "c_id_person" integer,
    "c_data_purchase" date
    CONSTRAINT FK_PERSON_PURCHASE FOREIGN KEY(c_id_person) references person(c_id_person),
    CONSTRAINT FK_PRODUCT_PURCHASE FOREIGN KEY(c_id_product) references person(c_id_product)
);

```
