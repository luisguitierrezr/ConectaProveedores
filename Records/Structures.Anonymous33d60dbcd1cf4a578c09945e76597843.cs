namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (vA3WM8_RV0qMCZRedll4Qw)
///  <code>RC_e3f679a5677e9bcd15fc4cdbc37afdac</code> that represent
/// s <code>UserInvoiceCommentRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceCommentRecord
public partial struct RC_e3f679a5677e9bcd15fc4cdbc37afdac : ITypedRecord<RC_e3f679a5677e9bcd15fc4cdbc37afdac> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoiceComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kwv_hVcV5hc0a5fTnTsCIg");

public ENUserEntityRecord ssENUser;

public EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord ssENInvoiceComment;


public BitArray OptimizedAttributes;

public RC_e3f679a5677e9bcd15fc4cdbc37afdac() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoiceComment = new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceComment.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoiceComment.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoiceComment.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENInvoiceComment.Read( r, ref index);
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
public void ReadIM(RC_e3f679a5677e9bcd15fc4cdbc37afdac r) {
this = r;
}


public static bool operator == (RC_e3f679a5677e9bcd15fc4cdbc37afdac a, RC_e3f679a5677e9bcd15fc4cdbc37afdac b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoiceComment != b.ssENInvoiceComment) return false;
return true;
}

public static bool operator != (RC_e3f679a5677e9bcd15fc4cdbc37afdac a, RC_e3f679a5677e9bcd15fc4cdbc37afdac b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e3f679a5677e9bcd15fc4cdbc37afdac)) return false;
return (this == (RC_e3f679a5677e9bcd15fc4cdbc37afdac)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoiceComment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoiceComment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoiceComment.InternalRecursiveSave();
}


public RC_e3f679a5677e9bcd15fc4cdbc37afdac Duplicate() {
RC_e3f679a5677e9bcd15fc4cdbc37afdac t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoiceComment = (EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord)this.ssENInvoiceComment.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "invoicecomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceComment")) variable.Value = ssENInvoiceComment; else variable.Optimized = true;
variable.SetFieldName("invoicecomment");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdInvoiceComment) {
return ssENInvoiceComment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdInvoiceComment.Key.AsGuid) {
return ssENInvoiceComment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoiceComment.FillFromOther((IRecord) other.AttributeGet(IdInvoiceComment));
}
} // RC_e3f679a5677e9bcd15fc4cdbc37afdac
/// <summary>
/// RecordList type <code>UserInvoiceCommentRecordList</code> that represents a record list of
///  <code>User, InvoiceComment</code>
/// </summary>
public partial class RL_2b8298c99eec97081abcd9d7211953b5 : GenericRecordList<RC_e3f679a5677e9bcd15fc4cdbc37afdac>, IEnumerable, IEnumerator {

protected override RC_e3f679a5677e9bcd15fc4cdbc37afdac GetElementDefaultValue() {
return new RC_e3f679a5677e9bcd15fc4cdbc37afdac();
}

public T[] ToArray<T>(Func<RC_e3f679a5677e9bcd15fc4cdbc37afdac, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2b8298c99eec97081abcd9d7211953b5 recordList, Func<RC_e3f679a5677e9bcd15fc4cdbc37afdac, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2b8298c99eec97081abcd9d7211953b5(RC_e3f679a5677e9bcd15fc4cdbc37afdac[] array) {
  RL_2b8298c99eec97081abcd9d7211953b5 result = new RL_2b8298c99eec97081abcd9d7211953b5();
result.InnerFromArray(array);
    return result;
}

public static RL_2b8298c99eec97081abcd9d7211953b5 ToList<T>(T[] array, Func <T, RC_e3f679a5677e9bcd15fc4cdbc37afdac> converter) {
  RL_2b8298c99eec97081abcd9d7211953b5 result = new RL_2b8298c99eec97081abcd9d7211953b5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2b8298c99eec97081abcd9d7211953b5 FromRestList<T>(RestList<T> restList, Func <T, RC_e3f679a5677e9bcd15fc4cdbc37afdac> converter) {
  RL_2b8298c99eec97081abcd9d7211953b5 result = new RL_2b8298c99eec97081abcd9d7211953b5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2b8298c99eec97081abcd9d7211953b5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(5,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e3f679a5677e9bcd15fc4cdbc37afdac> NewList() {
return new RL_2b8298c99eec97081abcd9d7211953b5();
}


} // RL_2b8298c99eec97081abcd9d7211953b5
}

