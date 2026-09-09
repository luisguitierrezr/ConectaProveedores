namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (IgWFChYPwEilMoi7NlAklA)
///  <code>RC_003d65e5661b449409d67ebedc16a923</code> that represent
/// s <code>InvoiceRequisitionRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceRequisitionRecord
public partial struct RC_003d65e5661b449409d67ebedc16a923 : ITypedRecord<RC_003d65e5661b449409d67ebedc16a923> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;


public BitArray OptimizedAttributes;

public RC_003d65e5661b449409d67ebedc16a923() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(58,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoice.Read( r, ref index);
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_003d65e5661b449409d67ebedc16a923 r) {
this = r;
}


public static bool operator == (RC_003d65e5661b449409d67ebedc16a923 a, RC_003d65e5661b449409d67ebedc16a923 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
return true;
}

public static bool operator != (RC_003d65e5661b449409d67ebedc16a923 a, RC_003d65e5661b449409d67ebedc16a923 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_003d65e5661b449409d67ebedc16a923)) return false;
return (this == (RC_003d65e5661b449409d67ebedc16a923)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENRequisition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENRequisition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
}


public RC_003d65e5661b449409d67ebedc16a923 Duplicate() {
RC_003d65e5661b449409d67ebedc16a923 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdRequisition) {
return ssENRequisition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
}
} // RC_003d65e5661b449409d67ebedc16a923
/// <summary>
/// RecordList type <code>InvoiceRequisitionRecordList</code> that represents a record list of
///  <code>Invoice, Requisition</code>
/// </summary>
public partial class RL_4d0a053561fa4a3aef04e507b83b31d1 : GenericRecordList<RC_003d65e5661b449409d67ebedc16a923>, IEnumerable, IEnumerator {

protected override RC_003d65e5661b449409d67ebedc16a923 GetElementDefaultValue() {
return new RC_003d65e5661b449409d67ebedc16a923();
}

public T[] ToArray<T>(Func<RC_003d65e5661b449409d67ebedc16a923, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4d0a053561fa4a3aef04e507b83b31d1 recordList, Func<RC_003d65e5661b449409d67ebedc16a923, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4d0a053561fa4a3aef04e507b83b31d1(RC_003d65e5661b449409d67ebedc16a923[] array) {
  RL_4d0a053561fa4a3aef04e507b83b31d1 result = new RL_4d0a053561fa4a3aef04e507b83b31d1();
result.InnerFromArray(array);
    return result;
}

public static RL_4d0a053561fa4a3aef04e507b83b31d1 ToList<T>(T[] array, Func <T, RC_003d65e5661b449409d67ebedc16a923> converter) {
  RL_4d0a053561fa4a3aef04e507b83b31d1 result = new RL_4d0a053561fa4a3aef04e507b83b31d1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4d0a053561fa4a3aef04e507b83b31d1 FromRestList<T>(RestList<T> restList, Func <T, RC_003d65e5661b449409d67ebedc16a923> converter) {
  RL_4d0a053561fa4a3aef04e507b83b31d1 result = new RL_4d0a053561fa4a3aef04e507b83b31d1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4d0a053561fa4a3aef04e507b83b31d1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(24,false);
def[1] = new BitArray(58,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_003d65e5661b449409d67ebedc16a923> NewList() {
return new RL_4d0a053561fa4a3aef04e507b83b31d1();
}


} // RL_4d0a053561fa4a3aef04e507b83b31d1
}

