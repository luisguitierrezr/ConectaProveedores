import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidCommentTooltip.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidCommentTooltip.mvc$controller.js";

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
}, createElement(OSWidgets$Expression, {
value: model.variables.getCommentsByProposalLineIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentAttr.messageAttr,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCommentsByProposalLineIdAggr.dataFetchStatusAttr)
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_UnpaidCommentTooltip",
functionKey: "e84a0b89-0b79-4c28-a6cb-3fe06173a9fc",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidCommentTooltip",
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
return [];
};


return ELEM;
};

export default componentFactory()
