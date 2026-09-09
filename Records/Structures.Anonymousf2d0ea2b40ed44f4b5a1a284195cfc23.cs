namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (K+rQ8u1A9ES1oaKEGVz8Iw)
///  <code>RC_ca28323a4fc03670541dd65eaae03cf2</code> that represent
/// s
///  <code>InvoiceAccountingServicesAccountingAccounts_ServiceTypeTaxIndicatorCostCenterSAPRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingServicesAccountingAccounts_ServiceTypeTaxIndicatorCostCenterSAPRecord
public partial struct RC_ca28323a4fc03670541dd65eaae03cf2 : ITypedRecord<RC_ca28323a4fc03670541dd65eaae03cf2> {
internal static readonly GlobalObjectKey IdInvoiceAccountingServices = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*e5pgWmJ73iwoWcpQZpD42w");
internal static readonly GlobalObjectKey IdAccountingAccounts_ServiceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*71wr9azPQUAiGVITzhtTug");
internal static readonly GlobalObjectKey IdTaxIndicator = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*K08LaPc4fWBh+vjvaP0mEw");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");

public EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord ssENInvoiceAccountingServices;

public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ssENAccountingAccounts_ServiceType;

public EN_efc751d189a1545503ba31ced5225e86EntityRecord ssENTaxIndicator;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;


public BitArray OptimizedAttributes;

public RC_ca28323a4fc03670541dd65eaae03cf2() {
OptimizedAttributes = null;
ssENInvoiceAccountingServices = new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord();
ssENAccountingAccounts_ServiceType = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
ssENTaxIndicator = new EN_efc751d189a1545503ba31ced5225e86EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingServices.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENTaxIndicator.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENInvoiceAccountingServices.OptimizedAttributes = value[0];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = value[1];
    ssENTaxIndicator.OptimizedAttributes = value[2];
    ssENCostCenterSAP.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENInvoiceAccountingServices.OptimizedAttributes;
    all[1] = ssENAccountingAccounts_ServiceType.OptimizedAttributes;
    all[2] = ssENTaxIndicator.OptimizedAttributes;
    all[3] = ssENCostCenterSAP.OptimizedAttributes;
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
ssENAccountingAccounts_ServiceType.Read( r, ref index);
ssENTaxIndicator.Read( r, ref index);
ssENCostCenterSAP.Read( r, ref index);
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
public void ReadIM(RC_ca28323a4fc03670541dd65eaae03cf2 r) {
this = r;
}


public static bool operator == (RC_ca28323a4fc03670541dd65eaae03cf2 a, RC_ca28323a4fc03670541dd65eaae03cf2 b) {
if (a.ssENInvoiceAccountingServices != b.ssENInvoiceAccountingServices) return false;
if (a.ssENAccountingAccounts_ServiceType != b.ssENAccountingAccounts_ServiceType) return false;
if (a.ssENTaxIndicator != b.ssENTaxIndicator) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
return true;
}

public static bool operator != (RC_ca28323a4fc03670541dd65eaae03cf2 a, RC_ca28323a4fc03670541dd65eaae03cf2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ca28323a4fc03670541dd65eaae03cf2)) return false;
return (this == (RC_ca28323a4fc03670541dd65eaae03cf2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingServices.GetHashCode()
 ^ ssENAccountingAccounts_ServiceType.GetHashCode()
 ^ ssENTaxIndicator.GetHashCode()
 ^ ssENCostCenterSAP.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccountingServices.RecursiveReset();
ssENAccountingAccounts_ServiceType.RecursiveReset();
ssENTaxIndicator.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingServices.InternalRecursiveSave();
ssENAccountingAccounts_ServiceType.InternalRecursiveSave();
ssENTaxIndicator.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
}


public RC_ca28323a4fc03670541dd65eaae03cf2 Duplicate() {
RC_ca28323a4fc03670541dd65eaae03cf2 t;
t.ssENInvoiceAccountingServices = (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord)this.ssENInvoiceAccountingServices.Duplicate();
t.ssENAccountingAccounts_ServiceType = (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord)this.ssENAccountingAccounts_ServiceType.Duplicate();
t.ssENTaxIndicator = (EN_efc751d189a1545503ba31ced5225e86EntityRecord)this.ssENTaxIndicator.Duplicate();
t.ssENCostCenterSAP = (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord)this.ssENCostCenterSAP.Duplicate();
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
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingAccounts_ServiceType")) variable.Value = ssENAccountingAccounts_ServiceType; else variable.Optimized = true;
variable.SetFieldName("accountingaccounts_servicetype");
} else if (head == "taxindicator") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TaxIndicator")) variable.Value = ssENTaxIndicator; else variable.Optimized = true;
variable.SetFieldName("taxindicator");
} else if (head == "costcentersap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterSAP")) variable.Value = ssENCostCenterSAP; else variable.Optimized = true;
variable.SetFieldName("costcentersap");
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
return ssENAccountingAccounts_ServiceType;
}
if (key == IdTaxIndicator) {
return ssENTaxIndicator;
}
if (key == IdCostCenterSAP) {
return ssENCostCenterSAP;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccountingServices.Key.AsGuid) {
return ssENInvoiceAccountingServices;
}
if (attributeKey == IdAccountingAccounts_ServiceType.Key.AsGuid) {
return ssENAccountingAccounts_ServiceType;
}
if (attributeKey == IdTaxIndicator.Key.AsGuid) {
return ssENTaxIndicator;
}
if (attributeKey == IdCostCenterSAP.Key.AsGuid) {
return ssENCostCenterSAP;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceAccountingServices.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingServices));
ssENAccountingAccounts_ServiceType.FillFromOther((IRecord) other.AttributeGet(IdAccountingAccounts_ServiceType));
ssENTaxIndicator.FillFromOther((IRecord) other.AttributeGet(IdTaxIndicator));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
}
} // RC_ca28323a4fc03670541dd65eaae03cf2
/// <summary>
/// RecordList type
///  <code>InvoiceAccountingServicesAccountingAccounts_ServiceTypeTaxIndicatorCostCenterSAPRecordList</c
/// ode> that represents a record list of <code>InvoiceAccountingServices,
///  AccountingAccounts_ServiceType, TaxIndicator, CostCenterSAP</code>
/// </summary>
public partial class RL_ab678aaff30585e5160f5c8982d816c7 : GenericRecordList<RC_ca28323a4fc03670541dd65eaae03cf2>, IEnumerable, IEnumerator {

protected override RC_ca28323a4fc03670541dd65eaae03cf2 GetElementDefaultValue() {
return new RC_ca28323a4fc03670541dd65eaae03cf2();
}

public T[] ToArray<T>(Func<RC_ca28323a4fc03670541dd65eaae03cf2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ab678aaff30585e5160f5c8982d816c7 recordList, Func<RC_ca28323a4fc03670541dd65eaae03cf2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ab678aaff30585e5160f5c8982d816c7(RC_ca28323a4fc03670541dd65eaae03cf2[] array) {
  RL_ab678aaff30585e5160f5c8982d816c7 result = new RL_ab678aaff30585e5160f5c8982d816c7();
result.InnerFromArray(array);
    return result;
}

public static RL_ab678aaff30585e5160f5c8982d816c7 ToList<T>(T[] array, Func <T, RC_ca28323a4fc03670541dd65eaae03cf2> converter) {
  RL_ab678aaff30585e5160f5c8982d816c7 result = new RL_ab678aaff30585e5160f5c8982d816c7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ab678aaff30585e5160f5c8982d816c7 FromRestList<T>(RestList<T> restList, Func <T, RC_ca28323a4fc03670541dd65eaae03cf2> converter) {
  RL_ab678aaff30585e5160f5c8982d816c7 result = new RL_ab678aaff30585e5160f5c8982d816c7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ab678aaff30585e5160f5c8982d816c7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(14,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ca28323a4fc03670541dd65eaae03cf2> NewList() {
return new RL_ab678aaff30585e5160f5c8982d816c7();
}


} // RL_ab678aaff30585e5160f5c8982d816c7
}

