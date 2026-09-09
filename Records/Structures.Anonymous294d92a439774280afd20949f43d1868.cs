namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pJJNKXc5gEKv0glJ9D0YaA)
///  <code>RC_edbb7c49338c371c22a2fa657a1d867d</code> that represent
/// s <code>InvoiceAccountingServicesInvoiceAccountingCeBeCostCenterSAPCostCenterSAPRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingServicesInvoiceAccountingCeBeCostCenterSAPCostCenterSAPRecord
public partial struct RC_edbb7c49338c371c22a2fa657a1d867d : ITypedRecord<RC_edbb7c49338c371c22a2fa657a1d867d> {
internal static readonly GlobalObjectKey IdInvoiceAccountingServices = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*e5pgWmJ73iwoWcpQZpD42w");
internal static readonly GlobalObjectKey IdInvoiceAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PqiYw9GniAlua+aT9tB4Zw");
internal static readonly GlobalObjectKey IdCeBeCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Qyof_OnuzUt_WypFMYz6bw");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");

public EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord ssENInvoiceAccountingServices;

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCeBeCostCenterSAP;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;


public BitArray OptimizedAttributes;

public RC_edbb7c49338c371c22a2fa657a1d867d() {
OptimizedAttributes = null;
ssENInvoiceAccountingServices = new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord();
ssENInvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
ssENCeBeCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(21,false);
    all[2] = new BitArray(25,false);
    all[3] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingServices.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENCeBeCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENInvoiceAccountingServices.OptimizedAttributes = value[0];
    ssENInvoiceAccounting.OptimizedAttributes = value[1];
    ssENCeBeCostCenterSAP.OptimizedAttributes = value[2];
    ssENCostCenterSAP.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENInvoiceAccountingServices.OptimizedAttributes;
    all[1] = ssENInvoiceAccounting.OptimizedAttributes;
    all[2] = ssENCeBeCostCenterSAP.OptimizedAttributes;
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
ssENInvoiceAccounting.Read( r, ref index);
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
public void ReadIM(RC_edbb7c49338c371c22a2fa657a1d867d r) {
this = r;
}


public static bool operator == (RC_edbb7c49338c371c22a2fa657a1d867d a, RC_edbb7c49338c371c22a2fa657a1d867d b) {
if (a.ssENInvoiceAccountingServices != b.ssENInvoiceAccountingServices) return false;
if (a.ssENInvoiceAccounting != b.ssENInvoiceAccounting) return false;
if (a.ssENCeBeCostCenterSAP != b.ssENCeBeCostCenterSAP) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
return true;
}

public static bool operator != (RC_edbb7c49338c371c22a2fa657a1d867d a, RC_edbb7c49338c371c22a2fa657a1d867d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_edbb7c49338c371c22a2fa657a1d867d)) return false;
return (this == (RC_edbb7c49338c371c22a2fa657a1d867d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingServices.GetHashCode()
 ^ ssENInvoiceAccounting.GetHashCode()
 ^ ssENCeBeCostCenterSAP.GetHashCode()
 ^ ssENCostCenterSAP.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccountingServices.RecursiveReset();
ssENInvoiceAccounting.RecursiveReset();
ssENCeBeCostCenterSAP.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingServices.InternalRecursiveSave();
ssENInvoiceAccounting.InternalRecursiveSave();
ssENCeBeCostCenterSAP.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
}


public RC_edbb7c49338c371c22a2fa657a1d867d Duplicate() {
RC_edbb7c49338c371c22a2fa657a1d867d t;
t.ssENInvoiceAccountingServices = (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord)this.ssENInvoiceAccountingServices.Duplicate();
t.ssENInvoiceAccounting = (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)this.ssENInvoiceAccounting.Duplicate();
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
} else if (head == "invoiceaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccounting")) variable.Value = ssENInvoiceAccounting; else variable.Optimized = true;
variable.SetFieldName("invoiceaccounting");
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
if (key == IdInvoiceAccounting) {
return ssENInvoiceAccounting;
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
if (attributeKey == IdInvoiceAccounting.Key.AsGuid) {
return ssENInvoiceAccounting;
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
ssENInvoiceAccounting.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccounting));
ssENCeBeCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCeBeCostCenterSAP));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
}
} // RC_edbb7c49338c371c22a2fa657a1d867d
/// <summary>
/// RecordList type
///  <code>InvoiceAccountingServicesInvoiceAccountingCeBeCostCenterSAPCostCenterSAPRecordList</code
/// > that represents a record list of <code>InvoiceAccountingServices, InvoiceAccounting,
///  CostCenterSAP, CostCenterSAP</code>
/// </summary>
public partial class RL_717be923c258f39ae670dbff1acf2ded : GenericRecordList<RC_edbb7c49338c371c22a2fa657a1d867d>, IEnumerable, IEnumerator {

protected override RC_edbb7c49338c371c22a2fa657a1d867d GetElementDefaultValue() {
return new RC_edbb7c49338c371c22a2fa657a1d867d();
}

public T[] ToArray<T>(Func<RC_edbb7c49338c371c22a2fa657a1d867d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_717be923c258f39ae670dbff1acf2ded recordList, Func<RC_edbb7c49338c371c22a2fa657a1d867d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_717be923c258f39ae670dbff1acf2ded(RC_edbb7c49338c371c22a2fa657a1d867d[] array) {
  RL_717be923c258f39ae670dbff1acf2ded result = new RL_717be923c258f39ae670dbff1acf2ded();
result.InnerFromArray(array);
    return result;
}

public static RL_717be923c258f39ae670dbff1acf2ded ToList<T>(T[] array, Func <T, RC_edbb7c49338c371c22a2fa657a1d867d> converter) {
  RL_717be923c258f39ae670dbff1acf2ded result = new RL_717be923c258f39ae670dbff1acf2ded();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_717be923c258f39ae670dbff1acf2ded FromRestList<T>(RestList<T> restList, Func <T, RC_edbb7c49338c371c22a2fa657a1d867d> converter) {
  RL_717be923c258f39ae670dbff1acf2ded result = new RL_717be923c258f39ae670dbff1acf2ded();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_717be923c258f39ae670dbff1acf2ded() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(14,false);
def[1] = new BitArray(21,false);
def[2] = new BitArray(25,false);
def[3] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_edbb7c49338c371c22a2fa657a1d867d> NewList() {
return new RL_717be923c258f39ae670dbff1acf2ded();
}


} // RL_717be923c258f39ae670dbff1acf2ded
}

