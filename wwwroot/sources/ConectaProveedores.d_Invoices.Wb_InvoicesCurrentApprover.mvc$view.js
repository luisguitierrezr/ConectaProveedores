import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_InvoicesCurrentApprover.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_InvoicesCurrentApprover.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_Text: model.getCachedValue(idService.getId("+OQQB5pC+EO5mA28EW+9pw.i_Text"), function () {
return ((((model.variables.getInvoiceApprovalsCurrentApproverAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr) !== (""))) ? (model.variables.getInvoiceApprovalsCurrentApproverAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr) : (model.variables.getInvoiceApprovalsCurrentApproverAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr));
}, function () {
return model.variables.getInvoiceApprovalsCurrentApproverAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr;
}, function () {
return model.variables.getInvoiceApprovalsCurrentApproverAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr;
}),
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceApprovalsCurrentApproverAggr.dataFetchStatusAttr)
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
_dependencies: []
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_InvoicesCurrentApprover",
functionKey: "625faa9b-4f48-4740-b89b-8b928fc40ff5",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_InvoicesCurrentApprover",
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
return [Telcel_Theme_Utils_Wb_ShortText_mvc_view];
};


return ELEM;
};

export default componentFactory()
