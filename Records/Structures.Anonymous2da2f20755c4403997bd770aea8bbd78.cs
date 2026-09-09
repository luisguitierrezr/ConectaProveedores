namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (B_KiLcRVOUCXvXcK6ou9eA)
///  <code>RC_3a3d5d4cc50f8572263073b452541424</code> that represent
/// s
///  <code>InvoiceAccountingServicesAccountingAccounts_ServiceTypeTaxIndicatorCeBeCostCenterSAPCostCente
/// rSAPRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingServicesAccountingAccounts_ServiceTypeTaxIndicatorCeBeCostCenterSAPCostCenterSAPRecord
public partial struct RC_3a3d5d4cc50f8572263073b452541424 : ITypedRecord<RC_3a3d5d4cc50f8572263073b452541424> {
internal static readonly GlobalObjectKey IdInvoiceAccountingServices = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*e5pgWmJ73iwoWcpQZpD42w");
internal static readonly GlobalObjectKey IdAccountingAccounts_ServiceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*71wr9azPQUAiGVITzhtTug");
internal static readonly GlobalObjectKey IdTaxIndicator = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*K08LaPc4fWBh+vjvaP0mEw");
internal static readonly GlobalObjectKey IdCeBeCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Qyof_OnuzUt_WypFMYz6bw");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");

public EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord ssENInvoiceAccountingServices;

public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ssENAccountingAccounts_ServiceType;

public EN_efc751d189a1545503ba31ced5225e86EntityRecord ssENTaxIndicator;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCeBeCostCenterSAP;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;


public BitArray OptimizedAttributes;

public RC_3a3d5d4cc50f8572263073b452541424() {
OptimizedAttributes = null;
ssENInvoiceAccountingServices = new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord();
ssENAccountingAccounts_ServiceType = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
ssENTaxIndicator = new EN_efc751d189a1545503ba31ced5225e86EntityRecord();
ssENCeBeCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(25,false);
    all[4] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingServices.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENTaxIndicator.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCeBeCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENInvoiceAccountingServices.OptimizedAttributes = value[0];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = value[1];
    ssENTaxIndicator.OptimizedAttributes = value[2];
    ssENCeBeCostCenterSAP.OptimizedAttributes = value[3];
    ssENCostCenterSAP.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENInvoiceAccountingServices.OptimizedAttributes;
    all[1] = ssENAccountingAccounts_ServiceType.OptimizedAttributes;
    all[2] = ssENTaxIndicator.OptimizedAttributes;
    all[3] = ssENCeBeCostCenterSAP.OptimizedAttributes;
    all[4] = ssENCostCenterSAP.OptimizedAttributes;
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
ssENCeBeCostCenterSAP.Read( r, ref index);
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
public void ReadIM(RC_3a3d5d4cc50f8572263073b452541424 r) {
this = r;
}


public static bool operator == (RC_3a3d5d4cc50f8572263073b452541424 a, RC_3a3d5d4cc50f8572263073b452541424 b) {
if (a.ssENInvoiceAccountingServices != b.ssENInvoiceAccountingServices) return false;
if (a.ssENAccountingAccounts_ServiceType != b.ssENAccountingAccounts_ServiceType) return false;
if (a.ssENTaxIndicator != b.ssENTaxIndicator) return false;
if (a.ssENCeBeCostCenterSAP != b.ssENCeBeCostCenterSAP) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
return true;
}

public static bool operator != (RC_3a3d5d4cc50f8572263073b452541424 a, RC_3a3d5d4cc50f8572263073b452541424 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3a3d5d4cc50f8572263073b452541424)) return false;
return (this == (RC_3a3d5d4cc50f8572263073b452541424)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingServices.GetHashCode()
 ^ ssENAccountingAccounts_ServiceType.GetHashCode()
 ^ ssENTaxIndicator.GetHashCode()
 ^ ssENCeBeCostCenterSAP.GetHashCode()
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
ssENCeBeCostCenterSAP.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingServices.InternalRecursiveSave();
ssENAccountingAccounts_ServiceType.InternalRecursiveSave();
ssENTaxIndicator.InternalRecursiveSave();
ssENCeBeCostCenterSAP.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
}


public RC_3a3d5d4cc50f8572263073b452541424 Duplicate() {
RC_3a3d5d4cc50f8572263073b452541424 t;
t.ssENInvoiceAccountingServices = (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord)this.ssENInvoiceAccountingServices.Duplicate();
t.ssENAccountingAccounts_ServiceType = (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord)this.ssENAccountingAccounts_ServiceType.Duplicate();
t.ssENTaxIndicator = (EN_efc751d189a1545503ba31ced5225e86EntityRecord)this.ssENTaxIndicator.Duplicate();
t.ssENCeBeCostCenterSAP = (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord)this.ssENCeBeCostCenterSAP.Duplicate();
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
} else if (head == "cebecostcentersap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CeBeCostCenterSAP")) variable.Value = ssENCeBeCostCenterSAP; else variable.Optimized = true;
variable.SetFieldName("cebecostcentersap");
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
if (key == IdCeBeCostCenterSAP) {
return ssENCeBeCostCenterSAP;
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
if (attributeKey == IdCeBeCostCenterSAP.Key.AsGuid) {
return ssENCeBeCostCenterSAP;
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
ssENCeBeCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCeBeCostCenterSAP));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
}
} // RC_3a3d5d4cc50f8572263073b452541424
/// <summary>
/// RecordList type
///  <code>InvoiceAccountingServicesAccountingAccounts_ServiceTypeTaxIndicatorCeBeCostCenterSAPCostCente
/// rSAPRecordList</code> that represents a record list of <code>InvoiceAccountingServices,
///  AccountingAccounts_ServiceType, TaxIndicator, CostCenterSAP, CostCenterSAP</code>
/// </summary>
public partial class RL_d55212981ba3c49c0fb66324f6a1411a : GenericRecordList<RC_3a3d5d4cc50f8572263073b452541424>, IEnumerable, IEnumerator {

protected override RC_3a3d5d4cc50f8572263073b452541424 GetElementDefaultValue() {
return new RC_3a3d5d4cc50f8572263073b452541424();
}

public T[] ToArray<T>(Func<RC_3a3d5d4cc50f8572263073b452541424, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d55212981ba3c49c0fb66324f6a1411a recordList, Func<RC_3a3d5d4cc50f8572263073b452541424, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d55212981ba3c49c0fb66324f6a1411a(RC_3a3d5d4cc50f8572263073b452541424[] array) {
  RL_d55212981ba3c49c0fb66324f6a1411a result = new RL_d55212981ba3c49c0fb66324f6a1411a();
result.InnerFromArray(array);
    return result;
}

public static RL_d55212981ba3c49c0fb66324f6a1411a ToList<T>(T[] array, Func <T, RC_3a3d5d4cc50f8572263073b452541424> converter) {
  RL_d55212981ba3c49c0fb66324f6a1411a result = new RL_d55212981ba3c49c0fb66324f6a1411a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d55212981ba3c49c0fb66324f6a1411a FromRestList<T>(RestList<T> restList, Func <T, RC_3a3d5d4cc50f8572263073b452541424> converter) {
  RL_d55212981ba3c49c0fb66324f6a1411a result = new RL_d55212981ba3c49c0fb66324f6a1411a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d55212981ba3c49c0fb66324f6a1411a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(14,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(25,false);
def[4] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3a3d5d4cc50f8572263073b452541424> NewList() {
return new RL_d55212981ba3c49c0fb66324f6a1411a();
}


} // RL_d55212981ba3c49c0fb66324f6a1411a
}

