import { withBaseWebBlock, Widget, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import Telcel_Theme_Theme_Layouts_Layout_Top_Menu_mvc_view from "./Telcel_Theme.Theme_Layouts.Layout_Top_Menu.mvc$view.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import Telcel_Theme_Theme_Common_HomepageMenu_mvc_view from "./Telcel_Theme.Theme_Common.HomepageMenu.mvc$view.js";
import ConectaProveedores_a_Common_UserInfo_mvc_view from "./ConectaProveedores.a_Common.UserInfo.mvc$view.js";
import { createElement } from "react";
import { Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import ConectaProveedores_y_Utils_wb_LoadingLayer_mvc_view from "./ConectaProveedores.y_Utils.wb_LoadingLayer.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Layouts.LayoutHomepage.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Layouts.LayoutHomepage.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(Telcel_Theme_Theme_Layouts_Layout_Top_Menu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
HasFixedHeader: model.variables.hasFixedHeaderIn,
_hasFixedHeaderInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._hasFixedHeaderInDataFetchStatus),
ExtendedClass: model.variables.extendedClassIn,
_extendedClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._extendedClassInDataFetchStatus),
EnableAccessibilityFeatures: model.variables.enableAccessibilityFeaturesIn,
_enableAccessibilityFeaturesInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._enableAccessibilityFeaturesInDataFetchStatus)
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
header: new Widget.PlaceholderContent(function () {
return [createElement(Telcel_Theme_Theme_Common_HomepageMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_HasAdminViewer: model.getCachedValue(idService.getId("4jrSsISTiUuUxawT8b36Vg.i_HasAdminViewer"), function () {
return ConectaProveedoresController$default.checkConectaProveedoresAdminViewerRole$Action(callContext).hasRoleOut;
}),
i_AsAuditorRole: model.getCachedValue(idService.getId("4jrSsISTiUuUxawT8b36Vg.i_AsAuditorRole"), function () {
return ConectaProveedoresController$default.checkTelcelUserAuditorRole$Action(callContext).hasRoleOut;
}),
i_Enviroment: model.variables.getSettingsDataAct.o_EnvironmentOut,
_i_EnviromentInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSettingsDataAct.dataFetchStatusAttr),
i_HasAdminRole: model.getCachedValue(idService.getId("4jrSsISTiUuUxawT8b36Vg.i_HasAdminRole"), function () {
return ConectaProveedoresController$default.checkConectaProveedoresAdminRole$Action(callContext).hasRoleOut;
}),
i_RegionAndRole: model.variables.getUserDataDataAct.o_RegionOut,
_i_RegionAndRoleInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDataDataAct.dataFetchStatusAttr)
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
uuid: "1",
alias: "2"
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
uuid: "2",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: []
})];
}),
breadcrumbs: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.breadcrumbs,
style: "content-breadcrumbs placeholder-empty",
_idProps: {
service: idService,
name: "Breadcrumbs"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.title,
style: "placeholder-empty",
_idProps: {
service: idService,
name: "Title"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.actions,
style: "placeholder-empty",
_idProps: {
service: idService,
name: "Actions"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.mainContent,
_idProps: {
service: idService,
name: "MainContent"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
footer: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.footer,
style: "placeholder-empty",
_idProps: {
service: idService,
name: "Footer"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(ConectaProveedores_y_Utils_wb_LoadingLayer_mvc_view, {
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
uuid: "8",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
}
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "LayoutHomepage",
functionKey: "96bf3e01-1cb1-43a4-be09-c95cd52e3b31",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Layouts.LayoutHomepage",
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
return [Telcel_Theme_Theme_Layouts_Layout_Top_Menu_mvc_view, Telcel_Theme_Theme_Common_HomepageMenu_mvc_view, ConectaProveedores_a_Common_UserInfo_mvc_view, ConectaProveedores_y_Utils_wb_LoadingLayer_mvc_view];
};


return ELEM;
};

export default componentFactory()
