import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FlowOptions.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FlowOptions.mvc$controller.js";

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
}, $if(model.variables.getApprovalProcessesDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory",
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NU9GQaCqWkmmsA9siYLOPg#Value", "Approval Workflow"))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionsList: model.getCachedValue(idService.getId("Dropdown.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getApprovalProcessesDataAct.approvalProcessesListOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.idAttr);
target.labelAttr = source.codeAttr;
target.groupNameAttr = source.groupAttr;
target.descriptionAttr = source.descriptionAttr;
return target;
});
}, function () {
return model.variables.getApprovalProcessesDataAct.approvalProcessesListOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApprovalProcessesDataAct.dataFetchStatusAttr),
OptionalConfigs: model.getCachedValue(idService.getId("Dropdown.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.noResultsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("YNL+_pCOdkG8zIz+kjuG1Q#Value.-1252356817.1", "No approval workflow to show...");
rec.searchPromptAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("RHE4JYIz+0eYA9RtEXF+bQ#Value.-512840794.1", "Search...");
rec.noOptionsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5mF9vEt13kerHnfJW+s9nA#Value.-1252356817.1", "No approval workflow to show...");
return rec;
}();
}),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("cmT5tSfTJUWfAdbvwxaIzg#Value.-1822154468.1", "Select")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSearchApprovProcessOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "Dropdown",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_FlowOptions",
functionKey: "64d82e81-408c-4e6a-a8a4-1fede8316687",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_FlowOptions",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_FlowOptions.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Interaction_DropdownSearch_mvc_view];
};


return ELEM;
};

export default componentFactory()
