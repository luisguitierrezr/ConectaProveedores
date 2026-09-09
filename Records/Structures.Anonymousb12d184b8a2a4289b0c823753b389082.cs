namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (SxgtsSqKiUKwyCN1OziQgg)
///  <code>RC_e84f9c9bcc5a701ba8257c06770fe241</code> that represent
/// s <code>InvoicesReport48_6ApprovalRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoicesReport48_6ApprovalRecord
public partial struct RC_e84f9c9bcc5a701ba8257c06770fe241 : ITypedRecord<RC_e84f9c9bcc5a701ba8257c06770fe241> {
internal static readonly GlobalObjectKey IdInvoicesReport48_6Approval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*m5xP6FrMG3CoJXwGdw_iQQ");

public ST_39962f5b1f9edd4db48277d9dcced378Structure ssSTInvoicesReport48_6Approval;


public static implicit operator ST_39962f5b1f9edd4db48277d9dcced378Structure( RC_e84f9c9bcc5a701ba8257c06770fe241 r) {
return r.ssSTInvoicesReport48_6Approval;
}

public static implicit operator RC_e84f9c9bcc5a701ba8257c06770fe241 (ST_39962f5b1f9edd4db48277d9dcced378Structure r) {
RC_e84f9c9bcc5a701ba8257c06770fe241 res = new RC_e84f9c9bcc5a701ba8257c06770fe241 ();
res.ssSTInvoicesReport48_6Approval = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e84f9c9bcc5a701ba8257c06770fe241() {
OptimizedAttributes = null;
ssSTInvoicesReport48_6Approval = new ST_39962f5b1f9edd4db48277d9dcced378Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTInvoicesReport48_6Approval.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTInvoicesReport48_6Approval.Read( r, ref index);
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
public void ReadIM(RC_e84f9c9bcc5a701ba8257c06770fe241 r) {
this = r;
}


public static bool operator == (RC_e84f9c9bcc5a701ba8257c06770fe241 a, RC_e84f9c9bcc5a701ba8257c06770fe241 b) {
if (a.ssSTInvoicesReport48_6Approval != b.ssSTInvoicesReport48_6Approval) return false;
return true;
}

public static bool operator != (RC_e84f9c9bcc5a701ba8257c06770fe241 a, RC_e84f9c9bcc5a701ba8257c06770fe241 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e84f9c9bcc5a701ba8257c06770fe241)) return false;
return (this == (RC_e84f9c9bcc5a701ba8257c06770fe241)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInvoicesReport48_6Approval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInvoicesReport48_6Approval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInvoicesReport48_6Approval.InternalRecursiveSave();
}


public RC_e84f9c9bcc5a701ba8257c06770fe241 Duplicate() {
RC_e84f9c9bcc5a701ba8257c06770fe241 t;
t.ssSTInvoicesReport48_6Approval = (ST_39962f5b1f9edd4db48277d9dcced378Structure)this.ssSTInvoicesReport48_6Approval.Duplicate();
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
if (head == "invoicesreport48_6approval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicesReport48_6Approval")) variable.Value = ssSTInvoicesReport48_6Approval; else variable.Optimized = true;
variable.SetFieldName("invoicesreport48_6approval");
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
if (key == IdInvoicesReport48_6Approval) {
return ssSTInvoicesReport48_6Approval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoicesReport48_6Approval.Key.AsGuid) {
return ssSTInvoicesReport48_6Approval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInvoicesReport48_6Approval.FillFromOther((IRecord) other.AttributeGet(IdInvoicesReport48_6Approval));
}
} // RC_e84f9c9bcc5a701ba8257c06770fe241
/// <summary>
/// RecordList type <code>InvoicesReport48_6ApprovalRecordList</code> that represents a record list of
///  <code>InvoicesReport48_6Approval</code>
/// </summary>
public partial class RL_d249bd57e30eef6ed5d14d884b62fe0c : GenericRecordList<RC_e84f9c9bcc5a701ba8257c06770fe241>, IEnumerable, IEnumerator {

protected override RC_e84f9c9bcc5a701ba8257c06770fe241 GetElementDefaultValue() {
return new RC_e84f9c9bcc5a701ba8257c06770fe241();
}

public T[] ToArray<T>(Func<RC_e84f9c9bcc5a701ba8257c06770fe241, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d249bd57e30eef6ed5d14d884b62fe0c recordList, Func<RC_e84f9c9bcc5a701ba8257c06770fe241, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d249bd57e30eef6ed5d14d884b62fe0c(RC_e84f9c9bcc5a701ba8257c06770fe241[] array) {
  RL_d249bd57e30eef6ed5d14d884b62fe0c result = new RL_d249bd57e30eef6ed5d14d884b62fe0c();
result.InnerFromArray(array);
    return result;
}

public static RL_d249bd57e30eef6ed5d14d884b62fe0c ToList<T>(T[] array, Func <T, RC_e84f9c9bcc5a701ba8257c06770fe241> converter) {
  RL_d249bd57e30eef6ed5d14d884b62fe0c result = new RL_d249bd57e30eef6ed5d14d884b62fe0c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d249bd57e30eef6ed5d14d884b62fe0c FromRestList<T>(RestList<T> restList, Func <T, RC_e84f9c9bcc5a701ba8257c06770fe241> converter) {
  RL_d249bd57e30eef6ed5d14d884b62fe0c result = new RL_d249bd57e30eef6ed5d14d884b62fe0c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d249bd57e30eef6ed5d14d884b62fe0c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e84f9c9bcc5a701ba8257c06770fe241> NewList() {
return new RL_d249bd57e30eef6ed5d14d884b62fe0c();
}


} // RL_d249bd57e30eef6ed5d14d884b62fe0c
}

