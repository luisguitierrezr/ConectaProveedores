namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (MOR8QEIohE2ejzMbOJoZKw)
///  <code>RC_3b5a20a3b041a6f2c3616e35c15dcd14</code> that represent
/// s <code>InvoiceIdInvoiceApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceIdInvoiceApprovalLevelRecord
public partial struct RC_3b5a20a3b041a6f2c3616e35c15dcd14 : ITypedRecord<RC_3b5a20a3b041a6f2c3616e35c15dcd14> {
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*cAEth7Cyg0VIBHF+qu7zgg");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoiceId;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;


public BitArray OptimizedAttributes;

public RC_3b5a20a3b041a6f2c3616e35c15dcd14() {
OptimizedAttributes = null;
ssENInvoiceId = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
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
    ssENInvoiceId.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoiceId.OptimizedAttributes = value[0];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoiceId.OptimizedAttributes;
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
ssENInvoiceId.Read( r, ref index);
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
public void ReadIM(RC_3b5a20a3b041a6f2c3616e35c15dcd14 r) {
this = r;
}


public static bool operator == (RC_3b5a20a3b041a6f2c3616e35c15dcd14 a, RC_3b5a20a3b041a6f2c3616e35c15dcd14 b) {
if (a.ssENInvoiceId != b.ssENInvoiceId) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
return true;
}

public static bool operator != (RC_3b5a20a3b041a6f2c3616e35c15dcd14 a, RC_3b5a20a3b041a6f2c3616e35c15dcd14 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3b5a20a3b041a6f2c3616e35c15dcd14)) return false;
return (this == (RC_3b5a20a3b041a6f2c3616e35c15dcd14)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceId.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceId.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceId.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
}


public RC_3b5a20a3b041a6f2c3616e35c15dcd14 Duplicate() {
RC_3b5a20a3b041a6f2c3616e35c15dcd14 t;
t.ssENInvoiceId = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoiceId.Duplicate();
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
if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssENInvoiceId; else variable.Optimized = true;
variable.SetFieldName("invoiceid");
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
if (key == IdInvoiceId) {
return ssENInvoiceId;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssENInvoiceId;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceId.FillFromOther((IRecord) other.AttributeGet(IdInvoiceId));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
}
} // RC_3b5a20a3b041a6f2c3616e35c15dcd14
/// <summary>
/// RecordList type <code>InvoiceIdInvoiceApprovalLevelRecordList</code> that represents a record list
///  of <code>Invoice, InvoiceApprovalLevel</code>
/// </summary>
public partial class RL_16fe63df6bf1bd188d61d0faface8fc0 : GenericRecordList<RC_3b5a20a3b041a6f2c3616e35c15dcd14>, IEnumerable, IEnumerator {

protected override RC_3b5a20a3b041a6f2c3616e35c15dcd14 GetElementDefaultValue() {
return new RC_3b5a20a3b041a6f2c3616e35c15dcd14();
}

public T[] ToArray<T>(Func<RC_3b5a20a3b041a6f2c3616e35c15dcd14, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_16fe63df6bf1bd188d61d0faface8fc0 recordList, Func<RC_3b5a20a3b041a6f2c3616e35c15dcd14, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_16fe63df6bf1bd188d61d0faface8fc0(RC_3b5a20a3b041a6f2c3616e35c15dcd14[] array) {
  RL_16fe63df6bf1bd188d61d0faface8fc0 result = new RL_16fe63df6bf1bd188d61d0faface8fc0();
result.InnerFromArray(array);
    return result;
}

public static RL_16fe63df6bf1bd188d61d0faface8fc0 ToList<T>(T[] array, Func <T, RC_3b5a20a3b041a6f2c3616e35c15dcd14> converter) {
  RL_16fe63df6bf1bd188d61d0faface8fc0 result = new RL_16fe63df6bf1bd188d61d0faface8fc0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_16fe63df6bf1bd188d61d0faface8fc0 FromRestList<T>(RestList<T> restList, Func <T, RC_3b5a20a3b041a6f2c3616e35c15dcd14> converter) {
  RL_16fe63df6bf1bd188d61d0faface8fc0 result = new RL_16fe63df6bf1bd188d61d0faface8fc0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_16fe63df6bf1bd188d61d0faface8fc0() : base() {
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
protected override OSList<RC_3b5a20a3b041a6f2c3616e35c15dcd14> NewList() {
return new RL_16fe63df6bf1bd188d61d0faface8fc0();
}


} // RL_16fe63df6bf1bd188d61d0faface8fc0
}

