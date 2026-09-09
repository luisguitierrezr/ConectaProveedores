namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6fcpjRd580WI1L5hin1nzg)
///  <code>RC_1b390f8e281aa018cfe8a81d34cdb757</code> that represent
/// s <code>FolioApprovalFolioFolioApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioApprovalFolioFolioApprovalLevelRecord
public partial struct RC_1b390f8e281aa018cfe8a81d34cdb757 : ITypedRecord<RC_1b390f8e281aa018cfe8a81d34cdb757> {
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;


public BitArray OptimizedAttributes;

public RC_1b390f8e281aa018cfe8a81d34cdb757() {
OptimizedAttributes = null;
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(10,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENFolioApproval.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENFolioApprovalLevel.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENFolioApproval.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENFolioApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_1b390f8e281aa018cfe8a81d34cdb757 r) {
this = r;
}


public static bool operator == (RC_1b390f8e281aa018cfe8a81d34cdb757 a, RC_1b390f8e281aa018cfe8a81d34cdb757 b) {
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
return true;
}

public static bool operator != (RC_1b390f8e281aa018cfe8a81d34cdb757 a, RC_1b390f8e281aa018cfe8a81d34cdb757 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1b390f8e281aa018cfe8a81d34cdb757)) return false;
return (this == (RC_1b390f8e281aa018cfe8a81d34cdb757)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioApproval.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioApproval.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
}


public RC_1b390f8e281aa018cfe8a81d34cdb757 Duplicate() {
RC_1b390f8e281aa018cfe8a81d34cdb757 t;
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
if (head == "folioapproval") {
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
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
}
} // RC_1b390f8e281aa018cfe8a81d34cdb757
/// <summary>
/// RecordList type <code>FolioApprovalFolioFolioApprovalLevelRecordList</code> that represents a
///  record list of <code>FolioApproval, Folio, FolioApprovalLevel</code>
/// </summary>
public partial class RL_ae9182bb38290e8d92b0cbd2d4f71569 : GenericRecordList<RC_1b390f8e281aa018cfe8a81d34cdb757>, IEnumerable, IEnumerator {

protected override RC_1b390f8e281aa018cfe8a81d34cdb757 GetElementDefaultValue() {
return new RC_1b390f8e281aa018cfe8a81d34cdb757();
}

public T[] ToArray<T>(Func<RC_1b390f8e281aa018cfe8a81d34cdb757, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ae9182bb38290e8d92b0cbd2d4f71569 recordList, Func<RC_1b390f8e281aa018cfe8a81d34cdb757, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ae9182bb38290e8d92b0cbd2d4f71569(RC_1b390f8e281aa018cfe8a81d34cdb757[] array) {
  RL_ae9182bb38290e8d92b0cbd2d4f71569 result = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
result.InnerFromArray(array);
    return result;
}

public static RL_ae9182bb38290e8d92b0cbd2d4f71569 ToList<T>(T[] array, Func <T, RC_1b390f8e281aa018cfe8a81d34cdb757> converter) {
  RL_ae9182bb38290e8d92b0cbd2d4f71569 result = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ae9182bb38290e8d92b0cbd2d4f71569 FromRestList<T>(RestList<T> restList, Func <T, RC_1b390f8e281aa018cfe8a81d34cdb757> converter) {
  RL_ae9182bb38290e8d92b0cbd2d4f71569 result = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ae9182bb38290e8d92b0cbd2d4f71569() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(10,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1b390f8e281aa018cfe8a81d34cdb757> NewList() {
return new RL_ae9182bb38290e8d92b0cbd2d4f71569();
}


} // RL_ae9182bb38290e8d92b0cbd2d4f71569
}

