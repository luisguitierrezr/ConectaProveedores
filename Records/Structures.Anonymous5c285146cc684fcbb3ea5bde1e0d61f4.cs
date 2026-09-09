namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (RlEoXGjMy0+z6lveHg1h9A)
///  <code>RC_e5232dda8695a6b53d7aafcc3b6d847f</code> that represents <code>File3Record</code
/// > <p>Description: </p>
/// </summary>
// Name: File3Record
public partial struct RC_e5232dda8695a6b53d7aafcc3b6d847f : ITypedRecord<RC_e5232dda8695a6b53d7aafcc3b6d847f> {
internal static readonly GlobalObjectKey IdFile3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2i0j5ZWGtaY9eq_MO22Efw");

public EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord ssENFile3;


public static implicit operator EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord( RC_e5232dda8695a6b53d7aafcc3b6d847f r) {
return r.ssENFile3;
}

public static implicit operator RC_e5232dda8695a6b53d7aafcc3b6d847f (EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord r) {
RC_e5232dda8695a6b53d7aafcc3b6d847f res = new RC_e5232dda8695a6b53d7aafcc3b6d847f ();
res.ssENFile3 = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFile3.ChangedAttributes = value;
}
get {
    return ssENFile3.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_e5232dda8695a6b53d7aafcc3b6d847f() {
OptimizedAttributes = null;
ssENFile3 = new EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFile3.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFile3.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFile3.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFile3.Read( r, ref index);
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
public void ReadIM(RC_e5232dda8695a6b53d7aafcc3b6d847f r) {
this = r;
}


public static bool operator == (RC_e5232dda8695a6b53d7aafcc3b6d847f a, RC_e5232dda8695a6b53d7aafcc3b6d847f b) {
if (a.ssENFile3 != b.ssENFile3) return false;
return true;
}

public static bool operator != (RC_e5232dda8695a6b53d7aafcc3b6d847f a, RC_e5232dda8695a6b53d7aafcc3b6d847f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e5232dda8695a6b53d7aafcc3b6d847f)) return false;
return (this == (RC_e5232dda8695a6b53d7aafcc3b6d847f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFile3.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFile3.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFile3.InternalRecursiveSave();
}


public RC_e5232dda8695a6b53d7aafcc3b6d847f Duplicate() {
RC_e5232dda8695a6b53d7aafcc3b6d847f t;
t.ssENFile3 = (EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord)this.ssENFile3.Duplicate();
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
if (head == "file3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".File3")) variable.Value = ssENFile3; else variable.Optimized = true;
variable.SetFieldName("file3");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFile3.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFile3.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFile3) {
return ssENFile3;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFile3.Key.AsGuid) {
return ssENFile3;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFile3.FillFromOther((IRecord) other.AttributeGet(IdFile3));
}
} // RC_e5232dda8695a6b53d7aafcc3b6d847f
/// <summary>
/// RecordList type <code>File3RecordList</code> that represents a record list of <code>File3</code>
/// </summary>
public partial class RL_08f794aa2125354ca78c75fb19e7e496 : GenericRecordList<RC_e5232dda8695a6b53d7aafcc3b6d847f>, IEnumerable, IEnumerator {

protected override RC_e5232dda8695a6b53d7aafcc3b6d847f GetElementDefaultValue() {
return new RC_e5232dda8695a6b53d7aafcc3b6d847f();
}

public T[] ToArray<T>(Func<RC_e5232dda8695a6b53d7aafcc3b6d847f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_08f794aa2125354ca78c75fb19e7e496 recordList, Func<RC_e5232dda8695a6b53d7aafcc3b6d847f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_08f794aa2125354ca78c75fb19e7e496(RC_e5232dda8695a6b53d7aafcc3b6d847f[] array) {
  RL_08f794aa2125354ca78c75fb19e7e496 result = new RL_08f794aa2125354ca78c75fb19e7e496();
result.InnerFromArray(array);
    return result;
}

public static RL_08f794aa2125354ca78c75fb19e7e496 ToList<T>(T[] array, Func <T, RC_e5232dda8695a6b53d7aafcc3b6d847f> converter) {
  RL_08f794aa2125354ca78c75fb19e7e496 result = new RL_08f794aa2125354ca78c75fb19e7e496();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_08f794aa2125354ca78c75fb19e7e496 FromRestList<T>(RestList<T> restList, Func <T, RC_e5232dda8695a6b53d7aafcc3b6d847f> converter) {
  RL_08f794aa2125354ca78c75fb19e7e496 result = new RL_08f794aa2125354ca78c75fb19e7e496();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_08f794aa2125354ca78c75fb19e7e496() : base() {
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
protected override OSList<RC_e5232dda8695a6b53d7aafcc3b6d847f> NewList() {
return new RL_08f794aa2125354ca78c75fb19e7e496();
}


} // RL_08f794aa2125354ca78c75fb19e7e496
}

