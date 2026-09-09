namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EgoI59i46EW0Dg7eihHlFg)
///  <code>RC_ab183c41bd8594296e7d4471350fb29f</code> that represent
/// s <code>FolioFolioApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioFolioApprovalLevelRecord
public partial struct RC_ab183c41bd8594296e7d4471350fb29f : ITypedRecord<RC_ab183c41bd8594296e7d4471350fb29f> {
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;


public BitArray OptimizedAttributes;

public RC_ab183c41bd8594296e7d4471350fb29f() {
OptimizedAttributes = null;
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENFolio.OptimizedAttributes = value[0];
    ssENFolioApprovalLevel.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENFolio.OptimizedAttributes;
    all[1] = ssENFolioApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_ab183c41bd8594296e7d4471350fb29f r) {
this = r;
}


public static bool operator == (RC_ab183c41bd8594296e7d4471350fb29f a, RC_ab183c41bd8594296e7d4471350fb29f b) {
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
return true;
}

public static bool operator != (RC_ab183c41bd8594296e7d4471350fb29f a, RC_ab183c41bd8594296e7d4471350fb29f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ab183c41bd8594296e7d4471350fb29f)) return false;
return (this == (RC_ab183c41bd8594296e7d4471350fb29f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolio.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolio.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
}


public RC_ab183c41bd8594296e7d4471350fb29f Duplicate() {
RC_ab183c41bd8594296e7d4471350fb29f t;
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
if (head == "folio") {
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdFolioApprovalLevel) {
return ssENFolioApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
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
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
}
} // RC_ab183c41bd8594296e7d4471350fb29f
/// <summary>
/// RecordList type <code>FolioFolioApprovalLevelRecordList</code> that represents a record list of
///  <code>Folio, FolioApprovalLevel</code>
/// </summary>
public partial class RL_bff3f4c3dd4f015750297ff735629582 : GenericRecordList<RC_ab183c41bd8594296e7d4471350fb29f>, IEnumerable, IEnumerator {

protected override RC_ab183c41bd8594296e7d4471350fb29f GetElementDefaultValue() {
return new RC_ab183c41bd8594296e7d4471350fb29f();
}

public T[] ToArray<T>(Func<RC_ab183c41bd8594296e7d4471350fb29f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bff3f4c3dd4f015750297ff735629582 recordList, Func<RC_ab183c41bd8594296e7d4471350fb29f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bff3f4c3dd4f015750297ff735629582(RC_ab183c41bd8594296e7d4471350fb29f[] array) {
  RL_bff3f4c3dd4f015750297ff735629582 result = new RL_bff3f4c3dd4f015750297ff735629582();
result.InnerFromArray(array);
    return result;
}

public static RL_bff3f4c3dd4f015750297ff735629582 ToList<T>(T[] array, Func <T, RC_ab183c41bd8594296e7d4471350fb29f> converter) {
  RL_bff3f4c3dd4f015750297ff735629582 result = new RL_bff3f4c3dd4f015750297ff735629582();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bff3f4c3dd4f015750297ff735629582 FromRestList<T>(RestList<T> restList, Func <T, RC_ab183c41bd8594296e7d4471350fb29f> converter) {
  RL_bff3f4c3dd4f015750297ff735629582 result = new RL_bff3f4c3dd4f015750297ff735629582();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bff3f4c3dd4f015750297ff735629582() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(20,false);
def[1] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ab183c41bd8594296e7d4471350fb29f> NewList() {
return new RL_bff3f4c3dd4f015750297ff735629582();
}


} // RL_bff3f4c3dd4f015750297ff735629582
}

