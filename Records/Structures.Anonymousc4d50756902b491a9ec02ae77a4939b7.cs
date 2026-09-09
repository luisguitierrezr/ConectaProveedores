namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (VgfVxCuQGkmewCrnekk5tw)
///  <code>RC_7e7b9dfb6acc38af212baa91da8cd5bf</code> that represent
/// s <code>UserInvoiceApprovalInvoiceApprovalLevelUser_Extended_InternalDepartmentRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: UserInvoiceApprovalInvoiceApprovalLevelUser_Extended_InternalDepartmentRecord
public partial struct RC_7e7b9dfb6acc38af212baa91da8cd5bf : ITypedRecord<RC_7e7b9dfb6acc38af212baa91da8cd5bf> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdDepartment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IzSRoKR0M7PMRMnTx82Mqg");

public ENUserEntityRecord ssENUser;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord ssENDepartment;


public BitArray OptimizedAttributes;

public RC_7e7b9dfb6acc38af212baa91da8cd5bf() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENDepartment = new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(25,false);
    all[3] = new BitArray(20,false);
    all[4] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENDepartment.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoiceApproval.OptimizedAttributes = value[1];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[2];
    ssENUser_Extended_Internal.OptimizedAttributes = value[3];
    ssENDepartment.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoiceApproval.OptimizedAttributes;
    all[2] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    all[3] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[4] = ssENDepartment.OptimizedAttributes;
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
ssENInvoiceApproval.Read( r, ref index);
ssENInvoiceApprovalLevel.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
ssENDepartment.Read( r, ref index);
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
public void ReadIM(RC_7e7b9dfb6acc38af212baa91da8cd5bf r) {
this = r;
}


public static bool operator == (RC_7e7b9dfb6acc38af212baa91da8cd5bf a, RC_7e7b9dfb6acc38af212baa91da8cd5bf b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENDepartment != b.ssENDepartment) return false;
return true;
}

public static bool operator != (RC_7e7b9dfb6acc38af212baa91da8cd5bf a, RC_7e7b9dfb6acc38af212baa91da8cd5bf b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7e7b9dfb6acc38af212baa91da8cd5bf)) return false;
return (this == (RC_7e7b9dfb6acc38af212baa91da8cd5bf)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENDepartment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENDepartment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENDepartment.InternalRecursiveSave();
}


public RC_7e7b9dfb6acc38af212baa91da8cd5bf Duplicate() {
RC_7e7b9dfb6acc38af212baa91da8cd5bf t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
t.ssENDepartment = (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord)this.ssENDepartment.Duplicate();
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
} else if (head == "invoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApproval")) variable.Value = ssENInvoiceApproval; else variable.Optimized = true;
variable.SetFieldName("invoiceapproval");
} else if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
} else if (head == "department") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Department")) variable.Value = ssENDepartment; else variable.Optimized = true;
variable.SetFieldName("department");
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
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
if (key == IdDepartment) {
return ssENDepartment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdInvoiceApproval.Key.AsGuid) {
return ssENInvoiceApproval;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
if (attributeKey == IdDepartment.Key.AsGuid) {
return ssENDepartment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENDepartment.FillFromOther((IRecord) other.AttributeGet(IdDepartment));
}
} // RC_7e7b9dfb6acc38af212baa91da8cd5bf
/// <summary>
/// RecordList type
///  <code>UserInvoiceApprovalInvoiceApprovalLevelUser_Extended_InternalDepartmentRecordList</code> tha
/// t represents a record list of <code>User, InvoiceApproval, InvoiceApprovalLevel,
///  User_Extended_Internal, Department</code>
/// </summary>
public partial class RL_b4ddf0f42ca95f85f71ab38d7b039957 : GenericRecordList<RC_7e7b9dfb6acc38af212baa91da8cd5bf>, IEnumerable, IEnumerator {

protected override RC_7e7b9dfb6acc38af212baa91da8cd5bf GetElementDefaultValue() {
return new RC_7e7b9dfb6acc38af212baa91da8cd5bf();
}

public T[] ToArray<T>(Func<RC_7e7b9dfb6acc38af212baa91da8cd5bf, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b4ddf0f42ca95f85f71ab38d7b039957 recordList, Func<RC_7e7b9dfb6acc38af212baa91da8cd5bf, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b4ddf0f42ca95f85f71ab38d7b039957(RC_7e7b9dfb6acc38af212baa91da8cd5bf[] array) {
  RL_b4ddf0f42ca95f85f71ab38d7b039957 result = new RL_b4ddf0f42ca95f85f71ab38d7b039957();
result.InnerFromArray(array);
    return result;
}

public static RL_b4ddf0f42ca95f85f71ab38d7b039957 ToList<T>(T[] array, Func <T, RC_7e7b9dfb6acc38af212baa91da8cd5bf> converter) {
  RL_b4ddf0f42ca95f85f71ab38d7b039957 result = new RL_b4ddf0f42ca95f85f71ab38d7b039957();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b4ddf0f42ca95f85f71ab38d7b039957 FromRestList<T>(RestList<T> restList, Func <T, RC_7e7b9dfb6acc38af212baa91da8cd5bf> converter) {
  RL_b4ddf0f42ca95f85f71ab38d7b039957 result = new RL_b4ddf0f42ca95f85f71ab38d7b039957();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b4ddf0f42ca95f85f71ab38d7b039957() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(25,false);
def[3] = new BitArray(20,false);
def[4] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7e7b9dfb6acc38af212baa91da8cd5bf> NewList() {
return new RL_b4ddf0f42ca95f85f71ab38d7b039957();
}


} // RL_b4ddf0f42ca95f85f71ab38d7b039957
}

