namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (kpSfYKY7+EeYTE0cox3v7Q)
///  <code>RC_a977e4ee3fe611d1f9a8a51587df5f57</code> that represent
/// s <code>EntraRoleUser_Extended_InternalRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: EntraRoleUser_Extended_InternalRegionRecord
public partial struct RC_a977e4ee3fe611d1f9a8a51587df5f57 : ITypedRecord<RC_a977e4ee3fe611d1f9a8a51587df5f57> {
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_a977e4ee3fe611d1f9a8a51587df5f57() {
OptimizedAttributes = null;
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENEntraRole.OptimizedAttributes = value[0];
    ssENUser_Extended_Internal.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENEntraRole.OptimizedAttributes;
    all[1] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENEntraRole.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
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
public void ReadIM(RC_a977e4ee3fe611d1f9a8a51587df5f57 r) {
this = r;
}


public static bool operator == (RC_a977e4ee3fe611d1f9a8a51587df5f57 a, RC_a977e4ee3fe611d1f9a8a51587df5f57 b) {
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_a977e4ee3fe611d1f9a8a51587df5f57 a, RC_a977e4ee3fe611d1f9a8a51587df5f57 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a977e4ee3fe611d1f9a8a51587df5f57)) return false;
return (this == (RC_a977e4ee3fe611d1f9a8a51587df5f57)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENEntraRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENEntraRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_a977e4ee3fe611d1f9a8a51587df5f57 Duplicate() {
RC_a977e4ee3fe611d1f9a8a51587df5f57 t;
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
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
if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
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
if (key == IdEntraRole) {
return ssENEntraRole;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_a977e4ee3fe611d1f9a8a51587df5f57
/// <summary>
/// RecordList type <code>EntraRoleUser_Extended_InternalRegionRecordList</code> that represents a
///  record list of <code>EntraRole, User_Extended_Internal, Region</code>
/// </summary>
public partial class RL_39dfaa06ed57a2b72536c2b3070b1bce : GenericRecordList<RC_a977e4ee3fe611d1f9a8a51587df5f57>, IEnumerable, IEnumerator {

protected override RC_a977e4ee3fe611d1f9a8a51587df5f57 GetElementDefaultValue() {
return new RC_a977e4ee3fe611d1f9a8a51587df5f57();
}

public T[] ToArray<T>(Func<RC_a977e4ee3fe611d1f9a8a51587df5f57, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_39dfaa06ed57a2b72536c2b3070b1bce recordList, Func<RC_a977e4ee3fe611d1f9a8a51587df5f57, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_39dfaa06ed57a2b72536c2b3070b1bce(RC_a977e4ee3fe611d1f9a8a51587df5f57[] array) {
  RL_39dfaa06ed57a2b72536c2b3070b1bce result = new RL_39dfaa06ed57a2b72536c2b3070b1bce();
result.InnerFromArray(array);
    return result;
}

public static RL_39dfaa06ed57a2b72536c2b3070b1bce ToList<T>(T[] array, Func <T, RC_a977e4ee3fe611d1f9a8a51587df5f57> converter) {
  RL_39dfaa06ed57a2b72536c2b3070b1bce result = new RL_39dfaa06ed57a2b72536c2b3070b1bce();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_39dfaa06ed57a2b72536c2b3070b1bce FromRestList<T>(RestList<T> restList, Func <T, RC_a977e4ee3fe611d1f9a8a51587df5f57> converter) {
  RL_39dfaa06ed57a2b72536c2b3070b1bce result = new RL_39dfaa06ed57a2b72536c2b3070b1bce();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_39dfaa06ed57a2b72536c2b3070b1bce() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(6,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a977e4ee3fe611d1f9a8a51587df5f57> NewList() {
return new RL_39dfaa06ed57a2b72536c2b3070b1bce();
}


} // RL_39dfaa06ed57a2b72536c2b3070b1bce
}

