﻿CREATE TABLE [Fj_servindustrias].[fa_tarifario_facturacion_x_cliente_Af_Depreciacion] (
    [IdEmpresa]           INT           NOT NULL,
    [IdDepreciacion]      DECIMAL (18)  NOT NULL,
    [IdTarifario]         NUMERIC (18)  NOT NULL,
    [IdTipoDepreciacion]  INT           NOT NULL,
    [IdPeriodo]           INT           NOT NULL,
    [Descripcion]         VARCHAR (200) NULL,
    [Fecha_Depreciacion]  DATETIME      NOT NULL,
    [Num_Act_Depre]       INT           NOT NULL,
    [Valor_Tot_Act]       FLOAT (53)    NOT NULL,
    [Valor_Tot_Depre]     FLOAT (53)    NOT NULL,
    [Valor_Tot_DepreAcum] FLOAT (53)    NOT NULL,
    [Valot_Tot_Importe]   FLOAT (53)    NOT NULL,
    [IdUsuario]           VARCHAR (20)  NULL,
    [Fecha_Transac]       DATETIME      NULL,
    [IdUsuarioUltMod]     VARCHAR (20)  NULL,
    [Fecha_UltMod]        DATETIME      NULL,
    [IdUsuarioUltAnu]     VARCHAR (20)  NULL,
    [Fecha_UltAnu]        DATETIME      NULL,
    [MotivoAnula]         VARCHAR (100) NULL,
    [nom_pc]              VARCHAR (50)  NULL,
    [ip]                  VARCHAR (25)  NULL,
    [Estado]              CHAR (1)      NULL,
    CONSTRAINT [PK_Af_Depreciacion_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdDepreciacion] ASC, [IdTarifario] ASC),
    CONSTRAINT [FK_fa_tarifario_facturacion_x_cliente_Af_Depreciacion_fa_tarifario_facturacion_x_cliente] FOREIGN KEY ([IdEmpresa], [IdTarifario]) REFERENCES [Fj_servindustrias].[fa_tarifario_facturacion_x_cliente] ([IdEmpresa], [IdTarifario])
);



