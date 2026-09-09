namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (wapkk2Pfgk6XRm13PrnCbA)
///  <code>RC_7d9af3f1351b60af34cc932af3010814</code> that represent
/// s <code>InvoiceInvoiceApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceApprovalLevelRecord
public partial struct RC_7d9af3f1351b60af34cc932af3010814 : ITypedRecord<RC_7d9af3f1351b60af34cc932af3010814> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;


public BitArray OptimizedAttributes;

public RC_7d9af3f1351b60af34cc932af3010814() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceApprovalLevel.OptimizedAttributes;
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
ssENInvoiceApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_7d9af3f1351b60af34cc932af3010814 r) {
this = r;
}


public static bool operator == (RC_7d9af3f1351b60af34cc932af3010814 a, RC_7d9af3f1351b60af34cc932af3010814 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
return true;
}

public static bool operator != (RC_7d9af3f1351b60af34cc932af3010814 a, RC_7d9af3f1351b60af34cc932af3010814 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7d9af3f1351b60af34cc932af3010814)) return false;
return (this == (RC_7d9af3f1351b60af34cc932af3010814)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
}


public RC_7d9af3f1351b60af34cc932af3010814 Duplicate() {
RC_7d9af3f1351b60af34cc932af3010814 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
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
} else if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
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
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
}
} // RC_7d9af3f1351b60af34cc932af3010814
/// <summary>
/// RecordList type <code>InvoiceInvoiceApprovalLevelRecordList</code> that represents a record list of
///  <code>Invoice, InvoiceApprovalLevel</code>
/// </summary>
public partial class RL_09457db01df0de3852b9312cdd42fb2a : GenericRecordList<RC_7d9af3f1351b60af34cc932af3010814>, IEnumerable, IEnumerator {

protected override RC_7d9af3f1351b60af34cc932af3010814 GetElementDefaultValue() {
return new RC_7d9af3f1351b60af34cc932af3010814();
}

public T[] ToArray<T>(Func<RC_7d9af3f1351b60af34cc932af3010814, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_09457db01df0de3852b9312cdd42fb2a recordList, Func<RC_7d9af3f1351b60af34cc932af3010814, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_09457db01df0de3852b9312cdd42fb2a(RC_7d9af3f1351b60af34cc932af3010814[] array) {
  RL_09457db01df0de3852b9312cdd42fb2a result = new RL_09457db01df0de3852b9312cdd42fb2a();
result.InnerFromArray(array);
    return result;
}

public static RL_09457db01df0de3852b9312cdd42fb2a ToList<T>(T[] array, Func <T, RC_7d9af3f1351b60af34cc932af3010814> converter) {
  RL_09457db01df0de3852b9312cdd42fb2a result = new RL_09457db01df0de3852b9312cdd42fb2a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_09457db01df0de3852b9312cdd42fb2a FromRestList<T>(RestList<T> restList, Func <T, RC_7d9af3f1351b60af34cc932af3010814> converter) {
  RL_09457db01df0de3852b9312cdd42fb2a result = new RL_09457db01df0de3852b9312cdd42fb2a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_09457db01df0de3852b9312cdd42fb2a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(24,false);
def[1] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7d9af3f1351b60af34cc932af3010814> NewList() {
return new RL_09457db01df0de3852b9312cdd42fb2a();
}


} // RL_09457db01df0de3852b9312cdd42fb2a
}

