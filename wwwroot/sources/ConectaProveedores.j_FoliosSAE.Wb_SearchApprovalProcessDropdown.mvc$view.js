import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Input as OSWidgets$Input, Link as OSWidgets$Link, Icon as OSWidgets$Icon, List as OSWidgets$List, Expression as OSWidgets$Expression, Text as OSWidgets$Text } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Advanced_DropdownServerSide_mvc_view from "./OutSystemsUI.Advanced.DropdownServerSide.mvc$view.js";
import OutSystemsUI_Advanced_DropdownServerSideItem_mvc_view from "./OutSystemsUI.Advanced.DropdownServerSideItem.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SearchApprovalProcessDropdown.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SearchApprovalProcessDropdown.mvc$controller.js";

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
style: model.getCachedValue(idService.getId("Q3PO9eIKVEGWpZ2E3eNnqQ.Style"), function () {
return ("os-boxlabel" + ((model.variables.i_IsValidIn) ? ("") : (" dropdown-invalid")));
}, function () {
return model.variables.i_IsValidIn;
}),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsValidInDataFetchStatus)
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("iqRkVq+IcEik5Ai9p5PZxg.Style"), function () {
return ((model.variables.i_IsMandatoryIn) ? ("mandatory") : (""));
}, function () {
return model.variables.i_IsMandatoryIn;
}),
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsMandatoryInDataFetchStatus)
}, $text(getTranslation("znSh3xfN2E2_YgEiwH+bWA#Value", "Approval Process"))), createElement(OutSystemsUI_Advanced_DropdownServerSide_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsDisabled: model.variables.i_IsDisableIn,
_isDisabledInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsDisableInDataFetchStatus),
AllowMultipleSelection: false
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
uuid: "2",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
balloonSearchInput: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "wcag-hide-text",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("PpgKbBAuFk2hA3rKjjmHaw#Value", "Type to Search"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedProperties: {
autoComplete: "off"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Search*/ 8,
mandatory: false,
maxLength: 50,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.input_ApprovalProcessSearchTextOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yY9xRVGdBUmACEzkddE4Ug#ValueExpression.-512840794.1", "Search..."),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_ApprovalProcessSearchTextVar, function (value) {
model.variables.l_ApprovalProcessSearchTextVar = value;
}),
_idProps: {
service: idService,
name: "Input_ApprovalProcessSearchText"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
balloonSearchInputIcon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearApprovalProcess$Action(true, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
balloonContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getApprovalProcesssAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApprovalProcesssAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OutSystemsUI_Advanced_DropdownServerSideItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ItemId: OS$BuiltinFunctions.longIntegerToText(model.variables.getApprovalProcesssAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.idAttr),
_itemIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApprovalProcesssAggr.dataFetchStatusAttr),
IsSelected: model.variables.getApprovalProcessByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.idAttr.equals(model.variables.getApprovalProcesssAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.idAttr),
_isSelectedInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApprovalProcessByIdAggr.dataFetchStatusAttr, model.variables.getApprovalProcesssAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (dropdownServerSideItemIdIn, itemOptionIdIn, dropdownServerSideIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.refresh$Action(OS$BuiltinFunctions.longIntegerToIdentifier(OS$BuiltinFunctions.textToLongInteger(itemOptionIdIn)), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "8",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
dropdownItemContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getApprovalProcesssAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.codeAttr,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApprovalProcesssAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 12px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("5uRuUs5dE0i36ZD1l3Em1w.Value"), function () {
return (((((model.variables.getApprovalProcesssAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.groupAttr) !== (""))) ? ((("(" + model.variables.getApprovalProcesssAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.groupAttr) + ") ")) : ("")) + model.variables.getApprovalProcesssAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.descriptionAttr);
}, function () {
return model.variables.getApprovalProcesssAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.groupAttr;
}, function () {
return model.variables.getApprovalProcesssAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.descriptionAttr;
}),
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApprovalProcesssAggr.dataFetchStatusAttr)
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getApprovalProcesssAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalProcesssAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.descriptionAttr), asPrimitiveValue(model.variables.getApprovalProcesssAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.groupAttr), asPrimitiveValue(model.variables.getApprovalProcesssAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.codeAttr)]
})];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getApprovalProcessByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.idAttr), asPrimitiveValue(model.variables.getApprovalProcessByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalProcesssAggr.dataFetchStatusAttr)]
}), $if(model.variables.getApprovalProcesssAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "padding-s text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nNbStU8whE6FCo1yUPEsFQ#Value", "No options to show...")))];
}, function () {
return [];
})];
}),
balloonFooter: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.loadMoreOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("EOB9GmmNY0yt2DC7xwKIrw#Value", "Load more")))];
}),
selectedValues: new Widget.PlaceholderContent(function () {
return [$if((!(model.variables.getApprovalProcessByIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_Width10"
},
value: model.variables.getApprovalProcessByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.codeAttr,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApprovalProcessByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearApprovalProcess$Action(false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon clear-dropdown",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [$if(model.variables.i_IsFilterIn, false, this, function () {
return [createElement(OSWidgets$Text, {
style: "text-neutral-9",
text: [$text(getTranslation("t69Zf+fh_kSqRbkXAUDhwg#Value", "All"))],
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Text, {
style: "text-neutral-9",
text: [$text(getTranslation("mR2pOhsTn069rvhpGw82Mg#Value", "Select"))],
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_IsFilterIn), asPrimitiveValue(model.variables.getApprovalProcessByIdAggr.listOut.isEmpty), asPrimitiveValue(model.variables.getApprovalProcessByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.codeAttr), asPrimitiveValue(model.variables.getApprovalProcessByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.idAttr), asPrimitiveValue(model.variables._i_IsFilterInDataFetchStatus), asPrimitiveValue(model.variables.getApprovalProcessByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalProcesssAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalProcesssAggr.listOut), asPrimitiveValue(model.variables.l_ApprovalProcessSearchTextVar)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: (!(model.variables.i_IsValidIn)),
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsValidInDataFetchStatus)
}, createElement(OSWidgets$Text, {
style: "text-error font-size-xs",
text: [$text(getTranslation("bj1Uu2Tx8kuCFwC4BFsKyA#Value", "This field is mandatory"))],
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_SearchApprovalProcessDropdown",
functionKey: "cc3bda8e-24df-4bdd-a12f-982e0189e79d",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_SearchApprovalProcessDropdown",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_SearchApprovalProcessDropdown.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Advanced_DropdownServerSide_mvc_view, OutSystemsUI_Advanced_DropdownServerSideItem_mvc_view];
};


return ELEM;
};

export default componentFactory()
