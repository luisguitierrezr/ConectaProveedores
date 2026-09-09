namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (M79bzTsmgUKrFzNSc13GEQ)
///  <code>RC_e40e190961051a83f0f95a5985af6cdd</code> that represent
/// s <code>UserFolioApprovalFolioFolioApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: UserFolioApprovalFolioFolioApprovalLevelRecord
public partial struct RC_e40e190961051a83f0f95a5985af6cdd : ITypedRecord<RC_e40e190961051a83f0f95a5985af6cdd> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");

public ENUserEntityRecord ssENUser;

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;


public BitArray OptimizedAttributes;

public RC_e40e190961051a83f0f95a5985af6cdd() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENFolioApproval.OptimizedAttributes = value[1];
    ssENFolio.OptimizedAttributes = value[2];
    ssENFolioApprovalLevel.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENFolioApproval.OptimizedAttributes;
    all[2] = ssENFolio.OptimizedAttributes;
    all[3] = ssENFolioApprovalLevel.OptimizedAttributes;
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
public void ReadIM(RC_e40e190961051a83f0f95a5985af6cdd r) {
this = r;
}


public static bool operator == (RC_e40e190961051a83f0f95a5985af6cdd a, RC_e40e190961051a83f0f95a5985af6cdd b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
return true;
}

public static bool operator != (RC_e40e190961051a83f0f95a5985af6cdd a, RC_e40e190961051a83f0f95a5985af6cdd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e40e190961051a83f0f95a5985af6cdd)) return false;
return (this == (RC_e40e190961051a83f0f95a5985af6cdd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
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
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENFolioApproval.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
}


public RC_e40e190961051a83f0f95a5985af6cdd Duplicate() {
RC_e40e190961051a83f0f95a5985af6cdd t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
}
} // RC_e40e190961051a83f0f95a5985af6cdd
/// <summary>
/// RecordList type <code>UserFolioApprovalFolioFolioApprovalLevelRecordList</code> that represents a
///  record list of <code>User, FolioApproval, Folio, FolioApprovalLevel</code>
/// </summary>
public partial class RL_a811b54d11345a2c46a0dc7830ffa1de : GenericRecordList<RC_e40e190961051a83f0f95a5985af6cdd>, IEnumerable, IEnumerator {

protected override RC_e40e190961051a83f0f95a5985af6cdd GetElementDefaultValue() {
return new RC_e40e190961051a83f0f95a5985af6cdd();
}

public T[] ToArray<T>(Func<RC_e40e190961051a83f0f95a5985af6cdd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a811b54d11345a2c46a0dc7830ffa1de recordList, Func<RC_e40e190961051a83f0f95a5985af6cdd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a811b54d11345a2c46a0dc7830ffa1de(RC_e40e190961051a83f0f95a5985af6cdd[] array) {
  RL_a811b54d11345a2c46a0dc7830ffa1de result = new RL_a811b54d11345a2c46a0dc7830ffa1de();
result.InnerFromArray(array);
    return result;
}

public static RL_a811b54d11345a2c46a0dc7830ffa1de ToList<T>(T[] array, Func <T, RC_e40e190961051a83f0f95a5985af6cdd> converter) {
  RL_a811b54d11345a2c46a0dc7830ffa1de result = new RL_a811b54d11345a2c46a0dc7830ffa1de();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a811b54d11345a2c46a0dc7830ffa1de FromRestList<T>(RestList<T> restList, Func <T, RC_e40e190961051a83f0f95a5985af6cdd> converter) {
  RL_a811b54d11345a2c46a0dc7830ffa1de result = new RL_a811b54d11345a2c46a0dc7830ffa1de();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a811b54d11345a2c46a0dc7830ffa1de() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e40e190961051a83f0f95a5985af6cdd> NewList() {
return new RL_a811b54d11345a2c46a0dc7830ffa1de();
}


} // RL_a811b54d11345a2c46a0dc7830ffa1de
}

