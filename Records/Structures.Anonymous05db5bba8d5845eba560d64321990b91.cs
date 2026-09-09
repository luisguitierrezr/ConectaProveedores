namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ulvbBViN60WlYNZDIZkLkQ)
///  <code>RC_ba39f6bd3c228aee942545da8b2d8590</code> that represent
/// s
///  <code>UserFolioApprovalFolioFolioApprovalLevelOrderMainEntraRoleUser_Extended_InternalSupplierRegio
/// nRecord</code> <p>Description: </p>
/// </summary>
// Name: UserFolioApprovalFolioFolioApprovalLevelOrderMainEntraRoleUser_Extended_InternalSupplierRegionRecord
public partial struct RC_ba39f6bd3c228aee942545da8b2d8590 : ITypedRecord<RC_ba39f6bd3c228aee942545da8b2d8590> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public ENUserEntityRecord ssENUser;

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_ba39f6bd3c228aee942545da8b2d8590() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[9];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(20,false);
    all[4] = new BitArray(29,false);
    all[5] = new BitArray(6,false);
    all[6] = new BitArray(20,false);
    all[7] = new BitArray(28,false);
    all[8] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENFolioApproval.OptimizedAttributes = value[1];
    ssENFolio.OptimizedAttributes = value[2];
    ssENFolioApprovalLevel.OptimizedAttributes = value[3];
    ssENOrderMain.OptimizedAttributes = value[4];
    ssENEntraRole.OptimizedAttributes = value[5];
    ssENUser_Extended_Internal.OptimizedAttributes = value[6];
    ssENSupplier.OptimizedAttributes = value[7];
    ssENRegion.OptimizedAttributes = value[8];
    }
}
get{
    BitArray[] all = new BitArray[9];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENFolioApproval.OptimizedAttributes;
    all[2] = ssENFolio.OptimizedAttributes;
    all[3] = ssENFolioApprovalLevel.OptimizedAttributes;
    all[4] = ssENOrderMain.OptimizedAttributes;
    all[5] = ssENEntraRole.OptimizedAttributes;
    all[6] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[7] = ssENSupplier.OptimizedAttributes;
    all[8] = ssENRegion.OptimizedAttributes;
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
ssENFolioApproval.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENFolioApprovalLevel.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENEntraRole.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_ba39f6bd3c228aee942545da8b2d8590 r) {
this = r;
}


public static bool operator == (RC_ba39f6bd3c228aee942545da8b2d8590 a, RC_ba39f6bd3c228aee942545da8b2d8590 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_ba39f6bd3c228aee942545da8b2d8590 a, RC_ba39f6bd3c228aee942545da8b2d8590 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ba39f6bd3c228aee942545da8b2d8590)) return false;
return (this == (RC_ba39f6bd3c228aee942545da8b2d8590)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENFolioApproval.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENFolioApproval.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_ba39f6bd3c228aee942545da8b2d8590 Duplicate() {
RC_ba39f6bd3c228aee942545da8b2d8590 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "folioapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApproval")) variable.Value = ssENFolioApproval; else variable.Optimized = true;
variable.SetFieldName("folioapproval");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "folioapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevel")) variable.Value = ssENFolioApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("folioapprovallevel");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdFolioApproval) {
return ssENFolioApproval;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdFolioApprovalLevel) {
return ssENFolioApprovalLevel;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdEntraRole) {
return ssENEntraRole;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdFolioApproval.Key.AsGuid) {
return ssENFolioApproval;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdFolioApprovalLevel.Key.AsGuid) {
return ssENFolioApprovalLevel;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_ba39f6bd3c228aee942545da8b2d8590
/// <summary>
/// RecordList type
///  <code>UserFolioApprovalFolioFolioApprovalLevelOrderMainEntraRoleUser_Extended_InternalSupplierRegio
/// nRecordList</code> that represents a record list of <code>User, FolioApproval, Folio,
///  FolioApprovalLevel, OrderMain, EntraRole, User_Extended_Internal, Supplier, Region</code>
/// </summary>
public partial class RL_05510f5a58c68804a13d569cb160e3d1 : GenericRecordList<RC_ba39f6bd3c228aee942545da8b2d8590>, IEnumerable, IEnumerator {

protected override RC_ba39f6bd3c228aee942545da8b2d8590 GetElementDefaultValue() {
return new RC_ba39f6bd3c228aee942545da8b2d8590();
}

public T[] ToArray<T>(Func<RC_ba39f6bd3c228aee942545da8b2d8590, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_05510f5a58c68804a13d569cb160e3d1 recordList, Func<RC_ba39f6bd3c228aee942545da8b2d8590, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_05510f5a58c68804a13d569cb160e3d1(RC_ba39f6bd3c228aee942545da8b2d8590[] array) {
  RL_05510f5a58c68804a13d569cb160e3d1 result = new RL_05510f5a58c68804a13d569cb160e3d1();
result.InnerFromArray(array);
    return result;
}

public static RL_05510f5a58c68804a13d569cb160e3d1 ToList<T>(T[] array, Func <T, RC_ba39f6bd3c228aee942545da8b2d8590> converter) {
  RL_05510f5a58c68804a13d569cb160e3d1 result = new RL_05510f5a58c68804a13d569cb160e3d1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_05510f5a58c68804a13d569cb160e3d1 FromRestList<T>(RestList<T> restList, Func <T, RC_ba39f6bd3c228aee942545da8b2d8590> converter) {
  RL_05510f5a58c68804a13d569cb160e3d1 result = new RL_05510f5a58c68804a13d569cb160e3d1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_05510f5a58c68804a13d569cb160e3d1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[9];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(20,false);
def[4] = new BitArray(29,false);
def[5] = new BitArray(6,false);
def[6] = new BitArray(20,false);
def[7] = new BitArray(28,false);
def[8] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ba39f6bd3c228aee942545da8b2d8590> NewList() {
return new RL_05510f5a58c68804a13d569cb160e3d1();
}


} // RL_05510f5a58c68804a13d569cb160e3d1
}

