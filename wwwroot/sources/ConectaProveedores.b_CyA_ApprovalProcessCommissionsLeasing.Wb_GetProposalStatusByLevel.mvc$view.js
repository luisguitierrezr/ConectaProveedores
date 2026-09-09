import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.Wb_GetProposalStatusByLevel.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.Wb_GetProposalStatusByLevel.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.i_ApprovalStatusLabelIn,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_ApprovalStatusLabelInDataFetchStatus),
i_Class: model.variables.i_ClassIn,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_ClassInDataFetchStatus)
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
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_GetProposalStatusByLevel",
functionKey: "2ab0874d-c5b8-4cd6-b84d-2372a228b301",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_ApprovalProcessCommissionsLeasing.Wb_GetProposalStatusByLevel",
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
return [Telcel_Theme_Utils_Wb_Status_mvc_view];
};


return ELEM;
};

export default componentFactory()
