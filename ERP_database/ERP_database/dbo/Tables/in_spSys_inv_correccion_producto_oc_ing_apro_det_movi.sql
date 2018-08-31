﻿CREATE TABLE [dbo].[in_spSys_inv_correccion_producto_oc_ing_apro_det_movi] (
    [IdEmpresa]         INT          NOT NULL,
    [IdSucursal]        INT          NOT NULL,
    [IdBodega]          INT          NOT NULL,
    [IdMovi_inven_tipo] INT          NOT NULL,
    [IdNumMovi]         NUMERIC (18) NOT NULL,
    [Secuencia]         INT          NOT NULL,
    CONSTRAINT [PK_in_spSys_inv_correccion_producto_oc_ing_apro_det_movi] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdMovi_inven_tipo] ASC, [IdNumMovi] ASC, [Secuencia] ASC)
);

