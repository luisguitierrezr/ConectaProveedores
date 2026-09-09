namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (AHgewgHCdE+pvpCQ24F7fw)
///  <code>RC_908593a03afc462f5e9a47938601f707</code> that represents <code>UserAreaRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserAreaRecord
public partial struct RC_908593a03afc462f5e9a47938601f707 : ITypedRecord<RC_908593a03afc462f5e9a47938601f707> {
internal static readonly GlobalObjectKey IdUserArea = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*oJOFkPw6L0ZemkeThgH3Bw");

public EN_91436b6b897297e560f42a1f2d0c865cEntityRecord ssENUserArea;


public static implicit operator EN_91436b6b897297e560f42a1f2d0c865cEntityRecord( RC_908593a03afc462f5e9a47938601f707 r) {
return r.ssENUserArea;
}

public static implicit operator RC_908593a03afc462f5e9a47938601f707 (EN_91436b6b897297e560f42a1f2d0c865cEntityRecord r) {
RC_908593a03afc462f5e9a47938601f707 res = new RC_908593a03afc462f5e9a47938601f707 ();
res.ssENUserArea = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENUserArea.ChangedAttributes = value;
}
get {
    return ssENUserArea.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_908593a03afc462f5e9a47938601f707() {
OptimizedAttributes = null;
ssENUserArea = new EN_91436b6b897297e560f42a1f2d0c865cEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUserArea.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENUserArea.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENUserArea.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUserArea.Read( r, ref index);
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
public void ReadIM(RC_908593a03afc462f5e9a47938601f707 r) {
this = r;
}


public static bool operator == (RC_908593a03afc462f5e9a47938601f707 a, RC_908593a03afc462f5e9a47938601f707 b) {
if (a.ssENUserArea != b.ssENUserArea) return false;
return true;
}

public static bool operator != (RC_908593a03afc462f5e9a47938601f707 a, RC_908593a03afc462f5e9a47938601f707 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_908593a03afc462f5e9a47938601f707)) return false;
return (this == (RC_908593a03afc462f5e9a47938601f707)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUserArea.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUserArea.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUserArea.InternalRecursiveSave();
}


public RC_908593a03afc462f5e9a47938601f707 Duplicate() {
RC_908593a03afc462f5e9a47938601f707 t;
t.ssENUserArea = (EN_91436b6b897297e560f42a1f2d0c865cEntityRecord)this.ssENUserArea.Duplicate();
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
if (head == "userarea") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserArea")) variable.Value = ssENUserArea; else variable.Optimized = true;
variable.SetFieldName("userarea");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENUserArea.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENUserArea.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdUserArea) {
return ssENUserArea;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserArea.Key.AsGuid) {
return ssENUserArea;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUserArea.FillFromOther((IRecord) other.AttributeGet(IdUserArea));
}
} // RC_908593a03afc462f5e9a47938601f707
/// <summary>
/// RecordList type <code>UserAreaRecordList</code> that represents a record list of
///  <code>UserArea</code>
/// </summary>
public partial class RL_e2ca864e4949ed8462c944f1cb40d53d : GenericRecordList<RC_908593a03afc462f5e9a47938601f707>, IEnumerable, IEnumerator {

protected override RC_908593a03afc462f5e9a47938601f707 GetElementDefaultValue() {
return new RC_908593a03afc462f5e9a47938601f707();
}

public T[] ToArray<T>(Func<RC_908593a03afc462f5e9a47938601f707, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e2ca864e4949ed8462c944f1cb40d53d recordList, Func<RC_908593a03afc462f5e9a47938601f707, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e2ca864e4949ed8462c944f1cb40d53d(RC_908593a03afc462f5e9a47938601f707[] array) {
  RL_e2ca864e4949ed8462c944f1cb40d53d result = new RL_e2ca864e4949ed8462c944f1cb40d53d();
result.InnerFromArray(array);
    return result;
}

public static RL_e2ca864e4949ed8462c944f1cb40d53d ToList<T>(T[] array, Func <T, RC_908593a03afc462f5e9a47938601f707> converter) {
  RL_e2ca864e4949ed8462c944f1cb40d53d result = new RL_e2ca864e4949ed8462c944f1cb40d53d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e2ca864e4949ed8462c944f1cb40d53d FromRestList<T>(RestList<T> restList, Func <T, RC_908593a03afc462f5e9a47938601f707> converter) {
  RL_e2ca864e4949ed8462c944f1cb40d53d result = new RL_e2ca864e4949ed8462c944f1cb40d53d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e2ca864e4949ed8462c944f1cb40d53d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_908593a03afc462f5e9a47938601f707> NewList() {
return new RL_e2ca864e4949ed8462c944f1cb40d53d();
}


} // RL_e2ca864e4949ed8462c944f1cb40d53d
}

