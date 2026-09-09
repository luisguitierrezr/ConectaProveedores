import { withBaseWebBlock, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model } from "@outsystems/runtime-core-js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.wb_AccSelect.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.wb_AccSelect.mvc$controller.js";

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
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory",
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+7ucg__N2UacTSAwkcRiiw#Value", "Select Concept")))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("F6ArMFspZkeC1MkR_cgJAQ#Value.-1822469688.1", "Search"),
OptionsList: model.getCachedValue(idService.getId("C9ovxI0aGE+AiSVdzFMb3w.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getOrderAccountingsByOrderIdAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.orderAccConceptsAttr.idAttr);
target.labelAttr = source.accountingDataTypeAttr.labelAttr;
target.descriptionAttr = (((OS$BuiltinFunctions.decimalToText(source.orderAccConceptsAttr.amountAttr) + " | ") + source.orderMainAttr.currencyIdAttr) + ((!(source.orderAccConceptsAttr.paymentDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? ((" | " + OS$BuiltinFunctions.dateToText(source.orderAccConceptsAttr.paymentDateAttr))) : ("")));
return target;
});
}, function () {
return model.variables.getOrderAccountingsByOrderIdAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderAccountingsByOrderIdAggr.dataFetchStatusAttr),
OptionalConfigs: model.getCachedValue(idService.getId("C9ovxI0aGE+AiSVdzFMb3w.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.isDisabledAttr = (!(model.variables.isEnableIn));
rec.searchPromptAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("YxW5UNWtZkqbZaD0mKnxVA#Value.-1822469688.1", "Search");
rec.noOptionsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1jQMp055EEW2XmRGTXooXA#Value.1249201917.1", "No Concepts avalaible");
return rec;
}();
}, function () {
return model.variables.isEnableIn;
}),
_optionalConfigsInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._isEnableInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSearchOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
});
;
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
_dependencies: []
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "wb_AccSelect",
functionKey: "22b84fde-d098-40a2-a8fc-adc92480d8aa",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.wb_AccSelect",
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
return [OutSystemsUI_Interaction_DropdownSearch_mvc_view];
};


return ELEM;
};

export default componentFactory()
