import { withBaseWebBlock, Widget, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import Telcel_Theme_Theme_Common_Menu_mvc_view from "./Telcel_Theme.Theme_Common.Menu.mvc$view.js";
import ConectaProveedores_a_Common_UserInfo_mvc_view from "./ConectaProveedores.a_Common.UserInfo.mvc$view.js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.a_Common.Menu.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.Menu.mvc$controller.js";

var componentFactory = function () {
var ELEM = withBaseWebBlock(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var spanProvider = useTracing();
return createElement("div", props.rootNodeProperties, createElement(Telcel_Theme_Theme_Common_Menu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_hasDesviacionesRole: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_hasDesviacionesRole"), function () {
return ConectaProveedoresController$default.checkDesviacionesRole$Action(callContext).hasRoleOut;
}),
i_HasCyaAdminRole: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_HasCyaAdminRole"), function () {
return ConectaProveedoresController$default.checkComissionesArrendamientosAdminRole$Action(callContext).hasRoleOut;
}),
i_HasAdminRole: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_HasAdminRole"), function () {
return ConectaProveedoresController$default.checkConectaProveedoresAdminRole$Action(callContext).hasRoleOut;
}),
i_IsActiveDEV_HU13045: model.variables.getSettingsDataAct.o_IsActiveDEV_HU13045Out,
_i_IsActiveDEV_HU13045InDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSettingsDataAct.dataFetchStatusAttr),
i_IsActiveDEV_HU13047: model.variables.getSettingsDataAct.o_IsActiveDEV_HU13047Out,
_i_IsActiveDEV_HU13047InDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSettingsDataAct.dataFetchStatusAttr),
i_Enviroment: model.variables.getSettingsDataAct.o_EnvironmentOut,
_i_EnviromentInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSettingsDataAct.dataFetchStatusAttr),
ActiveSubItem: model.variables.activeSubItemIn,
_activeSubItemInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._activeSubItemInDataFetchStatus),
i_HasOrderRole: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_HasOrderRole"), function () {
return (ConectaProveedoresController$default.checkPedidosRole$Action(callContext).hasRoleOut || ConectaProveedoresController$default.checkConectaProveedoresAdminRole$Action(callContext).hasRoleOut);
}),
i_HasOrderSapImportRole: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_HasOrderSapImportRole"), function () {
return ConectaProveedoresController$default.checkSAPImportOrdersRole$Action(callContext).hasRoleOut;
}),
i_IsActiveDEV_HU13046: model.variables.getSettingsDataAct.o_IsActiveDEV_HU13046Out,
_i_IsActiveDEV_HU13046InDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSettingsDataAct.dataFetchStatusAttr),
i_HasCyaViewerRole: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_HasCyaViewerRole"), function () {
return ConectaProveedoresController$default.checkComissionesArrendamientosViewerRole$Action(callContext).hasRoleOut;
}),
i_RegionAndRole: model.variables.getUserDataDataAct.o_RegionOut,
_i_RegionAndRoleInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDataDataAct.dataFetchStatusAttr),
i_hasTreasuryRole: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_hasTreasuryRole"), function () {
return ConectaProveedoresController$default.checkTesoreriaRole$Action(callContext).hasRoleOut;
}),
i_IsCxP: model.variables.getUserDataDataAct.o_IsCXPOut,
_i_IsCxPInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDataDataAct.dataFetchStatusAttr),
i_ViewRequisition: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_ViewRequisition"), function () {
return (ConectaProveedoresController$default.checkRequisicionesRole$Action(callContext).hasRoleOut || ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut);
}),
i_HasCyaRole: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_HasCyaRole"), function () {
return (ConectaProveedoresController$default.checkComissionesArrendamientosRole$Action(callContext).hasRoleOut && (!((ConectaProveedoresController$default.checkTesoreriaRole$Action(callContext).hasRoleOut || ConectaProveedoresController$default.checkComissionesArrendamientosAdminRole$Action(callContext).hasRoleOut))));
}),
i_IsActiveDEV_HU13048: model.variables.getSettingsDataAct.o_IsActiveDEV_HU13048Out,
_i_IsActiveDEV_HU13048InDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSettingsDataAct.dataFetchStatusAttr),
i_IsAuditor: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_IsAuditor"), function () {
return ConectaProveedoresController$default.checkTelcelUserAuditorRole$Action(callContext).hasRoleOut;
}),
i_IsProveedor: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_IsProveedor"), function () {
return ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut;
}),
i_HasFolioRole: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_HasFolioRole"), function () {
return ConectaProveedoresController$default.checkFoliosRole$Action(callContext).hasRoleOut;
}),
i_CanSeeDistributionError: model.variables.getUserDataDataAct.o_CanSeeDistributionErrorOut,
_i_CanSeeDistributionErrorInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDataDataAct.dataFetchStatusAttr),
ActiveItem: model.variables.activeItemIn,
_activeItemInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._activeItemInDataFetchStatus),
i_hasHistoricalAccess: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_hasHistoricalAccess"), function () {
return ConectaProveedoresController$default.checkHistoricoRole$Action(callContext).hasRoleOut;
}),
i_IsReportes: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_IsReportes"), function () {
return ConectaProveedoresController$default.checkReportesRole$Action(callContext).hasRoleOut;
}),
i_HasAlmacenRole: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_HasAlmacenRole"), function () {
return ConectaProveedoresController$default.checkAlmacenRole$Action(callContext).hasRoleOut;
}),
i_HasAdminViewer: model.getCachedValue(idService.getId("4avy9pApMEi7CjDIXlDFQg.i_HasAdminViewer"), function () {
return ConectaProveedoresController$default.checkConectaProveedoresAdminViewerRole$Action(callContext).hasRoleOut;
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
userInfo: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_a_Common_UserInfo_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "1",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: []
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Menu",
functionKey: "b2857a22-a038-40c7-b5b3-930c0f832969",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.Menu",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [Telcel_Theme_Theme_Common_Menu_mvc_view, ConectaProveedores_a_Common_UserInfo_mvc_view];
};


return ELEM;
};

export default componentFactory()
