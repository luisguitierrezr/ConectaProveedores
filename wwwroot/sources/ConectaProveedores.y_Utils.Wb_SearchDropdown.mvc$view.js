import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Input as OSWidgets$Input, Link as OSWidgets$Link, Icon as OSWidgets$Icon, List as OSWidgets$List, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import OutSystemsUI_Advanced_DropdownServerSide_mvc_view from "./OutSystemsUI.Advanced.DropdownServerSide.mvc$view.js";
import { createElement } from "react";
import OutSystemsUI_Advanced_DropdownServerSideItem_mvc_view from "./OutSystemsUI.Advanced.DropdownServerSideItem.mvc$view.js";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_SearchDropdown.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_SearchDropdown.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(false, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Advanced_DropdownServerSide_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AllowMultipleSelection: false,
IsDisabled: (!(model.variables.isEnabledIn)),
_isDisabledInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._isEnabledInDataFetchStatus)
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
placeholders: {
balloonSearchInput: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "wcag-hide-text",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("efrJzesbVUCyRhvG0LmMsQ#Value", "Type to search"))), createElement(OSWidgets$Input, {
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
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.refresh$Action(model.variables.maxRecordsIn, model.variables.searchTextVar, controller.callContext(eventHandlerContext));

;
},
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("sa7PDYkrxUOtMxIJ+zo2Rw#ValueExpression.-512840794.1", "Search..."),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.searchTextVar, function (value) {
model.variables.searchTextVar = value;
}),
_idProps: {
service: idService,
name: "Input_SupplierSearchText"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
balloonSearchInputIcon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearSupplierDrop$Action(controller.callContext(eventHandlerContext));
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
source: model.variables.itemsListIn,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._itemsListInDataFetchStatus),
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
ItemId: OS$BuiltinFunctions.longIntegerToText(model.variables.itemsListIn.getCurrent(callContext.iterationContext).idAttr),
_itemIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._itemsListInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (dropdownServerSideItemIdIn, itemOptionIdIn, dropdownServerSideIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownServerSideItemOnSelected$Action(itemOptionIdIn, controller.callContext(eventHandlerContext));
});
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
value: model.variables.itemsListIn.getCurrent(callContext.iterationContext).nameAttr,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._itemsListInDataFetchStatus)
})), $if(((model.variables.itemsListIn.getCurrent(callContext.iterationContext).textAttr) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 12px;"
},
gridProperties: {
classes: "ThemeGrid_Width8"
},
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.itemsListIn.getCurrent(callContext.iterationContext).textAttr,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._itemsListInDataFetchStatus)
}))];
}, function () {
return [];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables._itemsListInDataFetchStatus), asPrimitiveValue(model.variables.itemsListIn.getCurrent(callContext.iterationContext).textAttr), asPrimitiveValue(model.variables.itemsListIn.getCurrent(callContext.iterationContext).nameAttr)]
})];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables._itemsListInDataFetchStatus)]
}), $if(model.variables.itemsListIn.isEmpty, false, this, function () {
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
}, $text(getTranslation("eyQ+MIics0GBtdN3THe3ug#Value", "No options to show...")))];
}, function () {
return [];
})];
}),
balloonFooter: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.refresh$Action((model.variables.maxRecordsIn + 20), model.variables.searchTextVar, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("VOSCmbMRkEeINktut4CgIg#Value", "Load more")))];
}),
selectedValues: new Widget.PlaceholderContent(function () {
return [$if((model.variables.selectedNameIn === ""), false, this, function () {
return [createElement(OSWidgets$Expression, {
style: "text-neutral-9",
value: model.variables.i_PromptIn,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_PromptInDataFetchStatus)
})];
}, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.selectedNameIn,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._selectedNameInDataFetchStatus)
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_PromptIn), asPrimitiveValue(model.variables.selectedNameIn), asPrimitiveValue(model.variables._i_PromptInDataFetchStatus), asPrimitiveValue(model.variables._selectedNameInDataFetchStatus), asPrimitiveValue(model.variables._itemsListInDataFetchStatus), asPrimitiveValue(model.variables.itemsListIn), asPrimitiveValue(model.variables.searchTextVar)]
}))];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_SearchDropdown",
functionKey: "d0be3c3c-2e3f-4658-bde0-101ca3030de0",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_SearchDropdown",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.y_Utils.Wb_SearchDropdown.css"];
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
