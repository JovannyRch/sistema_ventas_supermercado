create table if not exists usuarios(
    id int unsigned  primary key auto_increment,
    email varchar(50) not null unique,
    pass varchar(100) not null
);

create table if not exists clientes(
    id int unsigned primary key auto_increment,
    nombre varchar(100),
    direccion varchar(100),
    telefono varchar(10)
);

create table if not exists facturas(
    id int unsigned primary key,
    id_cliente int unsigned not null,
    FOREIGN KEY (id_cliente) references clientes(id)  ON DELETE CASCADE,
    total float default 0.0,
    fecha DATETIME DEFAULT CURRENT_TIMESTAMP
);

create table categorias(
    id int unsigned primary key auto_increment,
    nombre varchar(50),
    descripcion varchar(100)
);


create table if not exists proveedores( 
    id int unsigned primary key auto_increment,
    nombre varchar(100),
    direccion varchar(100),
    telefono varchar(10)
);

create table if not exists pedidos(
    id int unsigned primary key auto_increment,
    id_producto int unsigned not null,
    FOREIGN KEY (id_producto) references productos(id)  ON DELETE CASCADE,
    id_proveedor int unsigned not null,
    FOREIGN KEY (id_proveedor) references proveedores(id)  ON DELETE CASCADE,
    cantidad int unsigned default 0,
    status varchar(20) default 'NO ENTREGADO',
    fecha DATETIME DEFAULT CURRENT_TIMESTAMP
);


create table if not exists productos(
    id int unsigned  primary key auto_increment,
    nombre varchar(50) not null unique,
    existencias int unsigned default 0,
    precio float default 0.0,
    marca varchar(50) default '',
    descripcion varchar(100),
    id_proveedor int unsigned not null,
    FOREIGN key (id_proveedor) references proveedores(id)  ON DELETE CASCADE,
    id_categoria int unsigned not null,
    FOREIGN key (id_categoria) references categorias(id)  ON DELETE CASCADE
);


create table if not exists ventas(
    id int unsigned  primary key auto_increment,
    id_factura int unsigned,
    FOREIGN key (id_factura) references facturas(id)  ON DELETE CASCADE,
    id_producto int unsigned,
    FOREIGN key (id_producto) references productos(id)  ON DELETE CASCADE,
    cantidad int
);



