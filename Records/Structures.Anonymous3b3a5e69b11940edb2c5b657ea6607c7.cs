namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (aV46Oxmx7UCyxbZX6mYHxw)
///  <code>RC_bc42b3285bc8089ad06a2c8ae4ee05e7</code> that represent
/// s <code>UserInvoiceApprovalInvoiceApprovalLevelEntraRoleUser_Extended_InternalRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: UserInvoiceApprovalInvoiceApprovalLevelEntraRoleUser_Extended_InternalRecord
public partial struct RC_bc42b3285bc8089ad06a2c8ae4ee05e7 : ITypedRecord<RC_bc42b3285bc8089ad06a2c8ae4ee05e7> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_bc42b3285bc8089ad06a2c8ae4ee05e7() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(25,false);
    all[3] = new BitArray(6,false);
    all[4] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoiceApproval.OptimizedAttributes = value[1];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[2];
    ssENEntraRole.OptimizedAttributes = value[3];
    ssENUser_Extended_Internal.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoiceApproval.OptimizedAttributes;
    all[2] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    all[3] = ssENEntraRole.OptimizedAttributes;
    all[4] = ssENUser_Extended_Internal.OptimizedAttributes;
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
ssENEntraRole.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
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
public void ReadIM(RC_bc42b3285bc8089ad06a2c8ae4ee05e7 r) {
this = r;
}


public static bool operator == (RC_bc42b3285bc8089ad06a2c8ae4ee05e7 a, RC_bc42b3285bc8089ad06a2c8ae4ee05e7 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_bc42b3285bc8089ad06a2c8ae4ee05e7 a, RC_bc42b3285bc8089ad06a2c8ae4ee05e7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bc42b3285bc8089ad06a2c8ae4ee05e7)) return false;
return (this == (RC_bc42b3285bc8089ad06a2c8ae4ee05e7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_bc42b3285bc8089ad06a2c8ae4ee05e7 Duplicate() {
RC_bc42b3285bc8089ad06a2c8ae4ee05e7 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
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
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
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
if (key == IdEntraRole) {
return ssENEntraRole;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
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
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_bc42b3285bc8089ad06a2c8ae4ee05e7
/// <summary>
/// RecordList type
///  <code>UserInvoiceApprovalInvoiceApprovalLevelEntraRoleUser_Extended_InternalRecordList</code> tha
/// t represents a record list of <code>User, InvoiceApproval, InvoiceApprovalLevel, EntraRole,
///  User_Extended_Internal</code>
/// </summary>
public partial class RL_1abe1514d325a5123b34272c27068edf : GenericRecordList<RC_bc42b3285bc8089ad06a2c8ae4ee05e7>, IEnumerable, IEnumerator {

protected override RC_bc42b3285bc8089ad06a2c8ae4ee05e7 GetElementDefaultValue() {
return new RC_bc42b3285bc8089ad06a2c8ae4ee05e7();
}

public T[] ToArray<T>(Func<RC_bc42b3285bc8089ad06a2c8ae4ee05e7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1abe1514d325a5123b34272c27068edf recordList, Func<RC_bc42b3285bc8089ad06a2c8ae4ee05e7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1abe1514d325a5123b34272c27068edf(RC_bc42b3285bc8089ad06a2c8ae4ee05e7[] array) {
  RL_1abe1514d325a5123b34272c27068edf result = new RL_1abe1514d325a5123b34272c27068edf();
result.InnerFromArray(array);
    return result;
}

public static RL_1abe1514d325a5123b34272c27068edf ToList<T>(T[] array, Func <T, RC_bc42b3285bc8089ad06a2c8ae4ee05e7> converter) {
  RL_1abe1514d325a5123b34272c27068edf result = new RL_1abe1514d325a5123b34272c27068edf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1abe1514d325a5123b34272c27068edf FromRestList<T>(RestList<T> restList, Func <T, RC_bc42b3285bc8089ad06a2c8ae4ee05e7> converter) {
  RL_1abe1514d325a5123b34272c27068edf result = new RL_1abe1514d325a5123b34272c27068edf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1abe1514d325a5123b34272c27068edf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(25,false);
def[3] = new BitArray(6,false);
def[4] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bc42b3285bc8089ad06a2c8ae4ee05e7> NewList() {
return new RL_1abe1514d325a5123b34272c27068edf();
}


} // RL_1abe1514d325a5123b34272c27068edf
}

