namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (C7Bg7vVBc0Sk9xYek__atA)
///  <code>RC_aa55fa7d9c7abf8c590a425e904bc1f7</code> that represent
/// s <code>NewNotification2Record</code> <p>Description: </p>
/// </summary>
// Name: NewNotification2Record
public partial struct RC_aa55fa7d9c7abf8c590a425e904bc1f7 : ITypedRecord<RC_aa55fa7d9c7abf8c590a425e904bc1f7> {
internal static readonly GlobalObjectKey IdNewNotification2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ffpVqnqcjL9ZCkJekEvB9w");

public ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure ssSTNewNotification2;


public static implicit operator ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure( RC_aa55fa7d9c7abf8c590a425e904bc1f7 r) {
return r.ssSTNewNotification2;
}

public static implicit operator RC_aa55fa7d9c7abf8c590a425e904bc1f7 (ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure r) {
RC_aa55fa7d9c7abf8c590a425e904bc1f7 res = new RC_aa55fa7d9c7abf8c590a425e904bc1f7 ();
res.ssSTNewNotification2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_aa55fa7d9c7abf8c590a425e904bc1f7() {
OptimizedAttributes = null;
ssSTNewNotification2 = new ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure();
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
    ssSTNewNotification2.OptimizedAttributes = value[0];
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
ssSTNewNotification2.Read( r, ref index);
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
public void ReadIM(RC_aa55fa7d9c7abf8c590a425e904bc1f7 r) {
this = r;
}


public static bool operator == (RC_aa55fa7d9c7abf8c590a425e904bc1f7 a, RC_aa55fa7d9c7abf8c590a425e904bc1f7 b) {
if (a.ssSTNewNotification2 != b.ssSTNewNotification2) return false;
return true;
}

public static bool operator != (RC_aa55fa7d9c7abf8c590a425e904bc1f7 a, RC_aa55fa7d9c7abf8c590a425e904bc1f7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_aa55fa7d9c7abf8c590a425e904bc1f7)) return false;
return (this == (RC_aa55fa7d9c7abf8c590a425e904bc1f7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTNewNotification2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTNewNotification2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTNewNotification2.InternalRecursiveSave();
}


public RC_aa55fa7d9c7abf8c590a425e904bc1f7 Duplicate() {
RC_aa55fa7d9c7abf8c590a425e904bc1f7 t;
t.ssSTNewNotification2 = (ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure)this.ssSTNewNotification2.Duplicate();
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
if (head == "newnotification2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NewNotification2")) variable.Value = ssSTNewNotification2; else variable.Optimized = true;
variable.SetFieldName("newnotification2");
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
if (key == IdNewNotification2) {
return ssSTNewNotification2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNewNotification2.Key.AsGuid) {
return ssSTNewNotification2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTNewNotification2.FillFromOther((IRecord) other.AttributeGet(IdNewNotification2));
}
} // RC_aa55fa7d9c7abf8c590a425e904bc1f7
/// <summary>
/// RecordList type <code>NewNotification2RecordList</code> that represents a record list of
///  <code>NewNotification2</code>
/// </summary>
public partial class RL_7344ccf1f50f9dfee9bf4c1cc6c6a866 : GenericRecordList<RC_aa55fa7d9c7abf8c590a425e904bc1f7>, IEnumerable, IEnumerator {

protected override RC_aa55fa7d9c7abf8c590a425e904bc1f7 GetElementDefaultValue() {
return new RC_aa55fa7d9c7abf8c590a425e904bc1f7();
}

public T[] ToArray<T>(Func<RC_aa55fa7d9c7abf8c590a425e904bc1f7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7344ccf1f50f9dfee9bf4c1cc6c6a866 recordList, Func<RC_aa55fa7d9c7abf8c590a425e904bc1f7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7344ccf1f50f9dfee9bf4c1cc6c6a866(RC_aa55fa7d9c7abf8c590a425e904bc1f7[] array) {
  RL_7344ccf1f50f9dfee9bf4c1cc6c6a866 result = new RL_7344ccf1f50f9dfee9bf4c1cc6c6a866();
result.InnerFromArray(array);
    return result;
}

public static RL_7344ccf1f50f9dfee9bf4c1cc6c6a866 ToList<T>(T[] array, Func <T, RC_aa55fa7d9c7abf8c590a425e904bc1f7> converter) {
  RL_7344ccf1f50f9dfee9bf4c1cc6c6a866 result = new RL_7344ccf1f50f9dfee9bf4c1cc6c6a866();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7344ccf1f50f9dfee9bf4c1cc6c6a866 FromRestList<T>(RestList<T> restList, Func <T, RC_aa55fa7d9c7abf8c590a425e904bc1f7> converter) {
  RL_7344ccf1f50f9dfee9bf4c1cc6c6a866 result = new RL_7344ccf1f50f9dfee9bf4c1cc6c6a866();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7344ccf1f50f9dfee9bf4c1cc6c6a866() : base() {
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
protected override OSList<RC_aa55fa7d9c7abf8c590a425e904bc1f7> NewList() {
return new RL_7344ccf1f50f9dfee9bf4c1cc6c6a866();
}


} // RL_7344ccf1f50f9dfee9bf4c1cc6c6a866
}

