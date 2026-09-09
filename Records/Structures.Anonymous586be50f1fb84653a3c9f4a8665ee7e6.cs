namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (D+VrWLgfU0ajyfSoZl7n5g)
///  <code>RC_bc68025e789d69992aef27aed0947c65</code> that represent
/// s <code>InvoiceInvoiceApprovalInvoiceApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceApprovalInvoiceApprovalLevelRecord
public partial struct RC_bc68025e789d69992aef27aed0947c65 : ITypedRecord<RC_bc68025e789d69992aef27aed0947c65> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;


public BitArray OptimizedAttributes;

public RC_bc68025e789d69992aef27aed0947c65() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceApproval.OptimizedAttributes = value[1];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceApproval.OptimizedAttributes;
    all[2] = ssENInvoiceApprovalLevel.OptimizedAttributes;
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
ssENInvoiceApproval.Read( r, ref index);
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
public void ReadIM(RC_bc68025e789d69992aef27aed0947c65 r) {
this = r;
}


public static bool operator == (RC_bc68025e789d69992aef27aed0947c65 a, RC_bc68025e789d69992aef27aed0947c65 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
return true;
}

public static bool operator != (RC_bc68025e789d69992aef27aed0947c65 a, RC_bc68025e789d69992aef27aed0947c65 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bc68025e789d69992aef27aed0947c65)) return false;
return (this == (RC_bc68025e789d69992aef27aed0947c65)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
}


public RC_bc68025e789d69992aef27aed0947c65 Duplicate() {
RC_bc68025e789d69992aef27aed0947c65 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
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
} else if (head == "invoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApproval")) variable.Value = ssENInvoiceApproval; else variable.Optimized = true;
variable.SetFieldName("invoiceapproval");
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
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
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
if (attributeKey == IdInvoiceApproval.Key.AsGuid) {
return ssENInvoiceApproval;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
}
} // RC_bc68025e789d69992aef27aed0947c65
/// <summary>
/// RecordList type <code>InvoiceInvoiceApprovalInvoiceApprovalLevelRecordList</code> that represents a
///  record list of <code>Invoice, InvoiceApproval, InvoiceApprovalLevel</code>
/// </summary>
public partial class RL_e8a2bfdbad62aa404e80d55d80faa387 : GenericRecordList<RC_bc68025e789d69992aef27aed0947c65>, IEnumerable, IEnumerator {

protected override RC_bc68025e789d69992aef27aed0947c65 GetElementDefaultValue() {
return new RC_bc68025e789d69992aef27aed0947c65();
}

public T[] ToArray<T>(Func<RC_bc68025e789d69992aef27aed0947c65, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e8a2bfdbad62aa404e80d55d80faa387 recordList, Func<RC_bc68025e789d69992aef27aed0947c65, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e8a2bfdbad62aa404e80d55d80faa387(RC_bc68025e789d69992aef27aed0947c65[] array) {
  RL_e8a2bfdbad62aa404e80d55d80faa387 result = new RL_e8a2bfdbad62aa404e80d55d80faa387();
result.InnerFromArray(array);
    return result;
}

public static RL_e8a2bfdbad62aa404e80d55d80faa387 ToList<T>(T[] array, Func <T, RC_bc68025e789d69992aef27aed0947c65> converter) {
  RL_e8a2bfdbad62aa404e80d55d80faa387 result = new RL_e8a2bfdbad62aa404e80d55d80faa387();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e8a2bfdbad62aa404e80d55d80faa387 FromRestList<T>(RestList<T> restList, Func <T, RC_bc68025e789d69992aef27aed0947c65> converter) {
  RL_e8a2bfdbad62aa404e80d55d80faa387 result = new RL_e8a2bfdbad62aa404e80d55d80faa387();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e8a2bfdbad62aa404e80d55d80faa387() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(24,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bc68025e789d69992aef27aed0947c65> NewList() {
return new RL_e8a2bfdbad62aa404e80d55d80faa387();
}


} // RL_e8a2bfdbad62aa404e80d55d80faa387
}

