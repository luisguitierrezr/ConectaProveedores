import { withBaseWebScreen, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { SystemActions as OS$SystemActions } from "@outsystems/runtime-core-js";
import ConectaProveedoresController$default, { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_a_Common_WB_ExternalUserProfile_mvc_view from "./ConectaProveedores.a_Common.WB_ExternalUserProfile.mvc$view.js";
import { createElement } from "react";
import ConectaProveedores_a_Common_WB_InternalUserProfile_mvc_view from "./ConectaProveedores.a_Common.WB_InternalUserProfile.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Common.UserProfile.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.UserProfile.mvc$controller.js";
import { ICON_LIBRARY_NAME, ICON_MAPPINGS, WEIGHT_MAPPINGS, SIZE_MAPPINGS } from "./Telcel_Theme.Telcel_Theme_Theme.mappings.js";

var componentFactory = function () {
var ELEM = withBaseWebScreen(function (props) {
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
return createElement("div", props.rootNodeProperties, $if((OS$SystemActions.isExternalUser(callContext).isExternalUserOut || ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut), false, this, function () {
return [createElement(ConectaProveedores_a_Common_WB_ExternalUserProfile_mvc_view, {
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(ConectaProveedores_a_Common_WB_InternalUserProfile_mvc_view, {
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
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "UserProfile",
functionKey: "d1f92804-a4fa-4d9e-a9cd-6ae1223130e4",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.UserProfile",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function (props) {
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
return ("Portal Conecta Proveedores " + ConectaProveedoresController$getEnviroment$Action(callContext).enviromentOut);
},
iconLibrary: ICON_LIBRARY_NAME,
iconMappings: ICON_MAPPINGS,
iconWeightMappings: WEIGHT_MAPPINGS,
iconSizeMappings: SIZE_MAPPINGS
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Common_WB_ExternalUserProfile_mvc_view, ConectaProveedores_a_Common_WB_InternalUserProfile_mvc_view];
};


return ELEM;
};

export default componentFactory()
