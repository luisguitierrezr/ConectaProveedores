namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2gCVSp9YPUeV0taa1578ig)
///  <code>RC_d8e0782722e3cf21d33f17c1d3072275</code> that represent
/// s
///  <code>UserInvoiceInvoiceApprovalInvoiceApprovalLevelApplicationRoleDoNotEntraSearchUser_Extended_In
/// ternalRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceInvoiceApprovalInvoiceApprovalLevelApplicationRoleDoNotEntraSearchUser_Extended_InternalRecord
public partial struct RC_d8e0782722e3cf21d33f17c1d3072275 : ITypedRecord<RC_d8e0782722e3cf21d33f17c1d3072275> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdDoNotEntraSearch = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vlwPJZ6SSI7IrTMO_y0IIg");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public bool ssDoNotEntraSearch;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_d8e0782722e3cf21d33f17c1d3072275() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssDoNotEntraSearch = false;
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(25,false);
    all[4] = new BitArray(7,false);
    all[5] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENInvoiceApproval.OptimizedAttributes = value[2];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[3];
    ssENApplicationRole.OptimizedAttributes = value[4];
    ssENUser_Extended_Internal.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENInvoiceApproval.OptimizedAttributes;
    all[3] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    all[4] = ssENApplicationRole.OptimizedAttributes;
    all[5] = ssENUser_Extended_Internal.OptimizedAttributes;
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
ssENInvoice.Read( r, ref index);
ssENInvoiceApproval.Read( r, ref index);
ssENInvoiceApprovalLevel.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
ssDoNotEntraSearch = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceApprovalLevelApplicationRoleDoNotEntraSearchUser_Extended_InternalRecord.DoNotEntraSearch", false);
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
public void ReadIM(RC_d8e0782722e3cf21d33f17c1d3072275 r) {
this = r;
}


public static bool operator == (RC_d8e0782722e3cf21d33f17c1d3072275 a, RC_d8e0782722e3cf21d33f17c1d3072275 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssDoNotEntraSearch != b.ssDoNotEntraSearch) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_d8e0782722e3cf21d33f17c1d3072275 a, RC_d8e0782722e3cf21d33f17c1d3072275 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d8e0782722e3cf21d33f17c1d3072275)) return false;
return (this == (RC_d8e0782722e3cf21d33f17c1d3072275)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssDoNotEntraSearch.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
ssENApplicationRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_d8e0782722e3cf21d33f17c1d3072275 Duplicate() {
RC_d8e0782722e3cf21d33f17c1d3072275 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssDoNotEntraSearch = this.ssDoNotEntraSearch;
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
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApproval")) variable.Value = ssENInvoiceApproval; else variable.Optimized = true;
variable.SetFieldName("invoiceapproval");
} else if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
} else if (head == "donotentrasearch") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DoNotEntraSearch")) variable.Value = ssDoNotEntraSearch; else variable.Optimized = true;
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
if (key == IdDoNotEntraSearch) {
return ssDoNotEntraSearch;
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
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceApproval.Key.AsGuid) {
return ssENInvoiceApproval;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
if (attributeKey == IdDoNotEntraSearch.Key.AsGuid) {
return ssDoNotEntraSearch;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssDoNotEntraSearch = (bool) other.AttributeGet(IdDoNotEntraSearch);
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_d8e0782722e3cf21d33f17c1d3072275
/// <summary>
/// RecordList type
///  <code>UserInvoiceInvoiceApprovalInvoiceApprovalLevelApplicationRoleDoNotEntraSearchUser_Extended_In
/// ternalRecordList</code> that represents a record list of <code>User, Invoice, InvoiceApproval,
///  InvoiceApprovalLevel, ApplicationRole, Boolean, User_Extended_Internal</code>
/// </summary>
public partial class RL_cff357eb9416ff34aed51af5aed473de : GenericRecordList<RC_d8e0782722e3cf21d33f17c1d3072275>, IEnumerable, IEnumerator {

protected override RC_d8e0782722e3cf21d33f17c1d3072275 GetElementDefaultValue() {
return new RC_d8e0782722e3cf21d33f17c1d3072275();
}

public T[] ToArray<T>(Func<RC_d8e0782722e3cf21d33f17c1d3072275, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cff357eb9416ff34aed51af5aed473de recordList, Func<RC_d8e0782722e3cf21d33f17c1d3072275, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cff357eb9416ff34aed51af5aed473de(RC_d8e0782722e3cf21d33f17c1d3072275[] array) {
  RL_cff357eb9416ff34aed51af5aed473de result = new RL_cff357eb9416ff34aed51af5aed473de();
result.InnerFromArray(array);
    return result;
}

public static RL_cff357eb9416ff34aed51af5aed473de ToList<T>(T[] array, Func <T, RC_d8e0782722e3cf21d33f17c1d3072275> converter) {
  RL_cff357eb9416ff34aed51af5aed473de result = new RL_cff357eb9416ff34aed51af5aed473de();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cff357eb9416ff34aed51af5aed473de FromRestList<T>(RestList<T> restList, Func <T, RC_d8e0782722e3cf21d33f17c1d3072275> converter) {
  RL_cff357eb9416ff34aed51af5aed473de result = new RL_cff357eb9416ff34aed51af5aed473de();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cff357eb9416ff34aed51af5aed473de() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(25,false);
def[4] = new BitArray(7,false);
def[5] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d8e0782722e3cf21d33f17c1d3072275> NewList() {
return new RL_cff357eb9416ff34aed51af5aed473de();
}


} // RL_cff357eb9416ff34aed51af5aed473de
}

