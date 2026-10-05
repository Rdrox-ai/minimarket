-- Ejecutar una sola vez en la base MINIMARKET (pgAdmin > Query Tool)

CREATE TABLE IF NOT EXISTS ventas (
    id_venta        SERIAL PRIMARY KEY,
    fecha           TIMESTAMP     NOT NULL DEFAULT NOW(),
    cliente_nombre  VARCHAR(150)  NOT NULL DEFAULT 'SIN NOMBRE',
    cliente_ruc     VARCHAR(30)   NOT NULL DEFAULT '---',
    subtotal        NUMERIC(14,2) NOT NULL,
    iva10           NUMERIC(14,2) NOT NULL DEFAULT 0,
    total           NUMERIC(14,2) NOT NULL,
    monto_recibido  NUMERIC(14,2) NOT NULL,
    vuelto          NUMERIC(14,2) NOT NULL DEFAULT 0,
    id_usuario      INTEGER       NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_ventas_fecha ON ventas (fecha);

CREATE TABLE IF NOT EXISTS ventas_detalle (
    id_detalle  SERIAL PRIMARY KEY,
    id_venta    INTEGER       NOT NULL REFERENCES ventas (id_venta) ON DELETE CASCADE,
    codigo      VARCHAR(50),
    producto    VARCHAR(200)  NOT NULL,
    precio      NUMERIC(14,2) NOT NULL,
    cantidad    NUMERIC(12,3) NOT NULL,
    subtotal    NUMERIC(14,2) NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_detalle_venta ON ventas_detalle (id_venta);


-- ===================== CONSULTAS DE RESUMEN (opcionales) =====================

-- Ventas por día
-- SELECT fecha::date AS dia, COUNT(*) AS cantidad_ventas, SUM(total) AS total_vendido
-- FROM ventas GROUP BY 1 ORDER BY 1 DESC;

-- Ventas por semana (PostgreSQL empieza la semana el lunes)
-- SELECT date_trunc('week', fecha)::date AS semana, COUNT(*) AS cantidad_ventas, SUM(total) AS total_vendido
-- FROM ventas GROUP BY 1 ORDER BY 1 DESC;

-- Ventas por mes
-- SELECT date_trunc('month', fecha)::date AS mes, COUNT(*) AS cantidad_ventas, SUM(total) AS total_vendido
-- FROM ventas GROUP BY 1 ORDER BY 1 DESC;

-- Productos más vendidos del mes actual
-- SELECT d.producto, SUM(d.cantidad) AS unidades, SUM(d.subtotal) AS total
-- FROM ventas_detalle d JOIN ventas v ON v.id_venta = d.id_venta
-- WHERE v.fecha >= date_trunc('month', CURRENT_DATE)
-- GROUP BY d.producto ORDER BY total DESC;

