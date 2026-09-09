namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (4eaLQrlWBEKZm1nfKAU90g)
///  <code>RC_3e9738e6e6c45aed847983a73298da67</code> that represent
/// s
///  <code>InvoiceAccountingServicesAccountingAccounts_ServiceTypeCostCenterSAPIndicatorIVARecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingServicesAccountingAccounts_ServiceTypeCostCenterSAPIndicatorIVARecord
public partial struct RC_3e9738e6e6c45aed847983a73298da67 : ITypedRecord<RC_3e9738e6e6c45aed847983a73298da67> {
internal static readonly GlobalObjectKey IdInvoiceAccountingServices = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*e5pgWmJ73iwoWcpQZpD42w");
internal static readonly GlobalObjectKey IdAccountingAccounts_ServiceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*64Rxv21OVxtzaPAo5tVPQg");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*h1KoR2xdWRDfCyyXoGvLDg");
internal static readonly GlobalObjectKey IdIndicatorIVA = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*K7P0sSY0dWh_+q44erQ9wg");

public EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord ssENInvoiceAccountingServices;

public string ssAccountingAccounts_ServiceType;

public string ssCostCenterSAP;

public string ssIndicatorIVA;


public BitArray OptimizedAttributes;

public RC_3e9738e6e6c45aed847983a73298da67() {
OptimizedAttributes = null;
ssENInvoiceAccountingServices = new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord();
ssAccountingAccounts_ServiceType = "";
ssCostCenterSAP = "";
ssIndicatorIVA = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(14,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingServices.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceAccountingServices.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceAccountingServices.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceAccountingServices.Read( r, ref index);
ssAccountingAccounts_ServiceType = r.ReadText(index++, "InvoiceAccountingServicesAccountingAccounts_ServiceTypeCostCenterSAPIndicatorIVARecord.AccountingAccounts_ServiceType", "");
ssCostCenterSAP = r.ReadText(index++, "InvoiceAccountingServicesAccountingAccounts_ServiceTypeCostCenterSAPIndicatorIVARecord.CostCenterSAP", "");
ssIndicatorIVA = r.ReadText(index++, "InvoiceAccountingServicesAccountingAccounts_ServiceTypeCostCenterSAPIndicatorIVARecord.IndicatorIVA", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(RC_3e9738e6e6c45aed847983a73298da67 r) {
this = r;
}


public static bool operator == (RC_3e9738e6e6c45aed847983a73298da67 a, RC_3e9738e6e6c45aed847983a73298da67 b) {
if (a.ssENInvoiceAccountingServices != b.ssENInvoiceAccountingServices) return false;
if (a.ssAccountingAccounts_ServiceType != b.ssAccountingAccounts_ServiceType) return false;
if (a.ssCostCenterSAP != b.ssCostCenterSAP) return false;
if (a.ssIndicatorIVA != b.ssIndicatorIVA) return false;
return true;
}

public static bool operator != (RC_3e9738e6e6c45aed847983a73298da67 a, RC_3e9738e6e6c45aed847983a73298da67 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3e9738e6e6c45aed847983a73298da67)) return false;
return (this == (RC_3e9738e6e6c45aed847983a73298da67)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingServices.GetHashCode()
 ^ ssAccountingAccounts_ServiceType.GetHashCode()
 ^ ssCostCenterSAP.GetHashCode()
 ^ ssIndicatorIVA.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccountingServices.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingServices.InternalRecursiveSave();
}


public RC_3e9738e6e6c45aed847983a73298da67 Duplicate() {
RC_3e9738e6e6c45aed847983a73298da67 t;
t.ssENInvoiceAccountingServices = (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord)this.ssENInvoiceAccountingServices.Duplicate();
t.ssAccountingAccounts_ServiceType = this.ssAccountingAccounts_ServiceType;
t.ssCostCenterSAP = this.ssCostCenterSAP;
t.ssIndicatorIVA = this.ssIndicatorIVA;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "invoiceaccountingservices") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingServices")) variable.Value = ssENInvoiceAccountingServices; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingservices");
} else if (head == "accountingaccounts_servicetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingAccounts_ServiceType")) variable.Value = ssAccountingAccounts_ServiceType; else variable.Optimized = true;
} else if (head == "costcentersap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterSAP")) variable.Value = ssCostCenterSAP; else variable.Optimized = true;
} else if (head == "indicatoriva") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IndicatorIVA")) variable.Value = ssIndicatorIVA; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceAccountingServices) {
return ssENInvoiceAccountingServices;
}
if (key == IdAccountingAccounts_ServiceType) {
return ssAccountingAccounts_ServiceType;
}
if (key == IdCostCenterSAP) {
return ssCostCenterSAP;
}
if (key == IdIndicatorIVA) {
return ssIndicatorIVA;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccountingServices.Key.AsGuid) {
return ssENInvoiceAccountingServices;
}
if (attributeKey == IdAccountingAccounts_ServiceType.Key.AsGuid) {
return ssAccountingAccounts_ServiceType;
}
if (attributeKey == IdCostCenterSAP.Key.AsGuid) {
return ssCostCenterSAP;
}
if (attributeKey == IdIndicatorIVA.Key.AsGuid) {
return ssIndicatorIVA;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceAccountingServices.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingServices));
ssAccountingAccounts_ServiceType = (string) other.AttributeGet(IdAccountingAccounts_ServiceType);
ssCostCenterSAP = (string) other.AttributeGet(IdCostCenterSAP);
ssIndicatorIVA = (string) other.AttributeGet(IdIndicatorIVA);
}
} // RC_3e9738e6e6c45aed847983a73298da67
/// <summary>
/// RecordList type
///  <code>InvoiceAccountingServicesAccountingAccounts_ServiceTypeCostCenterSAPIndicatorIVARecordList</c
/// ode> that represents a record list of <code>InvoiceAccountingServices, Text, Text, Text</code>
/// </summary>
public partial class RL_16e793224cf6c7166c0a8aab694ad751 : GenericRecordList<RC_3e9738e6e6c45aed847983a73298da67>, IEnumerable, IEnumerator {

protected override RC_3e9738e6e6c45aed847983a73298da67 GetElementDefaultValue() {
return new RC_3e9738e6e6c45aed847983a73298da67();
}

public T[] ToArray<T>(Func<RC_3e9738e6e6c45aed847983a73298da67, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_16e793224cf6c7166c0a8aab694ad751 recordList, Func<RC_3e9738e6e6c45aed847983a73298da67, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_16e793224cf6c7166c0a8aab694ad751(RC_3e9738e6e6c45aed847983a73298da67[] array) {
  RL_16e793224cf6c7166c0a8aab694ad751 result = new RL_16e793224cf6c7166c0a8aab694ad751();
result.InnerFromArray(array);
    return result;
}

public static RL_16e793224cf6c7166c0a8aab694ad751 ToList<T>(T[] array, Func <T, RC_3e9738e6e6c45aed847983a73298da67> converter) {
  RL_16e793224cf6c7166c0a8aab694ad751 result = new RL_16e793224cf6c7166c0a8aab694ad751();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_16e793224cf6c7166c0a8aab694ad751 FromRestList<T>(RestList<T> restList, Func <T, RC_3e9738e6e6c45aed847983a73298da67> converter) {
  RL_16e793224cf6c7166c0a8aab694ad751 result = new RL_16e793224cf6c7166c0a8aab694ad751();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_16e793224cf6c7166c0a8aab694ad751() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(14,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3e9738e6e6c45aed847983a73298da67> NewList() {
return new RL_16e793224cf6c7166c0a8aab694ad751();
}


} // RL_16e793224cf6c7166c0a8aab694ad751
}

