namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (yptsfUrEx0mcqEaVLR7dTg)
///  <code>RC_a1752e53585489f4261982ca1b7d6861</code> that represents <code>UniquesCeBeCeCoRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UniquesCeBeCeCoRecord
public partial struct RC_a1752e53585489f4261982ca1b7d6861 : ITypedRecord<RC_a1752e53585489f4261982ca1b7d6861> {
internal static readonly GlobalObjectKey IdUniquesCeBeCeCo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Uy51oVRY9IkmGYLKG31oYQ");

public ST_ec742cc5ff3341e853c9929e75681fd0Structure ssSTUniquesCeBeCeCo;


public static implicit operator ST_ec742cc5ff3341e853c9929e75681fd0Structure( RC_a1752e53585489f4261982ca1b7d6861 r) {
return r.ssSTUniquesCeBeCeCo;
}

public static implicit operator RC_a1752e53585489f4261982ca1b7d6861 (ST_ec742cc5ff3341e853c9929e75681fd0Structure r) {
RC_a1752e53585489f4261982ca1b7d6861 res = new RC_a1752e53585489f4261982ca1b7d6861 ();
res.ssSTUniquesCeBeCeCo = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a1752e53585489f4261982ca1b7d6861() {
OptimizedAttributes = null;
ssSTUniquesCeBeCeCo = new ST_ec742cc5ff3341e853c9929e75681fd0Structure();
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
    ssSTUniquesCeBeCeCo.OptimizedAttributes = value[0];
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
ssSTUniquesCeBeCeCo.Read( r, ref index);
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
public void ReadIM(RC_a1752e53585489f4261982ca1b7d6861 r) {
this = r;
}


public static bool operator == (RC_a1752e53585489f4261982ca1b7d6861 a, RC_a1752e53585489f4261982ca1b7d6861 b) {
if (a.ssSTUniquesCeBeCeCo != b.ssSTUniquesCeBeCeCo) return false;
return true;
}

public static bool operator != (RC_a1752e53585489f4261982ca1b7d6861 a, RC_a1752e53585489f4261982ca1b7d6861 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a1752e53585489f4261982ca1b7d6861)) return false;
return (this == (RC_a1752e53585489f4261982ca1b7d6861)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUniquesCeBeCeCo.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUniquesCeBeCeCo.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUniquesCeBeCeCo.InternalRecursiveSave();
}


public RC_a1752e53585489f4261982ca1b7d6861 Duplicate() {
RC_a1752e53585489f4261982ca1b7d6861 t;
t.ssSTUniquesCeBeCeCo = (ST_ec742cc5ff3341e853c9929e75681fd0Structure)this.ssSTUniquesCeBeCeCo.Duplicate();
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
if (head == "uniquescebececo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UniquesCeBeCeCo")) variable.Value = ssSTUniquesCeBeCeCo; else variable.Optimized = true;
variable.SetFieldName("uniquescebececo");
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
if (key == IdUniquesCeBeCeCo) {
return ssSTUniquesCeBeCeCo;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUniquesCeBeCeCo.Key.AsGuid) {
return ssSTUniquesCeBeCeCo;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUniquesCeBeCeCo.FillFromOther((IRecord) other.AttributeGet(IdUniquesCeBeCeCo));
}
} // RC_a1752e53585489f4261982ca1b7d6861
/// <summary>
/// RecordList type <code>UniquesCeBeCeCoRecordList</code> that represents a record list of
///  <code>UniquesCeBeCeCo</code>
/// </summary>
public partial class RL_2502f19d25781770de0a97334d85b782 : GenericRecordList<RC_a1752e53585489f4261982ca1b7d6861>, IEnumerable, IEnumerator {

protected override RC_a1752e53585489f4261982ca1b7d6861 GetElementDefaultValue() {
return new RC_a1752e53585489f4261982ca1b7d6861();
}

public T[] ToArray<T>(Func<RC_a1752e53585489f4261982ca1b7d6861, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2502f19d25781770de0a97334d85b782 recordList, Func<RC_a1752e53585489f4261982ca1b7d6861, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2502f19d25781770de0a97334d85b782(RC_a1752e53585489f4261982ca1b7d6861[] array) {
  RL_2502f19d25781770de0a97334d85b782 result = new RL_2502f19d25781770de0a97334d85b782();
result.InnerFromArray(array);
    return result;
}

public static RL_2502f19d25781770de0a97334d85b782 ToList<T>(T[] array, Func <T, RC_a1752e53585489f4261982ca1b7d6861> converter) {
  RL_2502f19d25781770de0a97334d85b782 result = new RL_2502f19d25781770de0a97334d85b782();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2502f19d25781770de0a97334d85b782 FromRestList<T>(RestList<T> restList, Func <T, RC_a1752e53585489f4261982ca1b7d6861> converter) {
  RL_2502f19d25781770de0a97334d85b782 result = new RL_2502f19d25781770de0a97334d85b782();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2502f19d25781770de0a97334d85b782() : base() {
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
protected override OSList<RC_a1752e53585489f4261982ca1b7d6861> NewList() {
return new RL_2502f19d25781770de0a97334d85b782();
}


} // RL_2502f19d25781770de0a97334d85b782
}

