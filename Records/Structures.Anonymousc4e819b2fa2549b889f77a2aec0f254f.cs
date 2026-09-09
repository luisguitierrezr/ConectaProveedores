namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (shnoxCX6uEmJ93oq7A8lTw)
///  <code>RC_a3650876f3c0ce24e984510abde7b989</code> that represents <code>ErroImportRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ErroImportRecord
public partial struct RC_a3650876f3c0ce24e984510abde7b989 : ITypedRecord<RC_a3650876f3c0ce24e984510abde7b989> {
internal static readonly GlobalObjectKey IdErroImport = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dghlo8DzJM7phFEKvee5iQ");

public ST_37eba272293c59d7cf1400fbd0fb4b40Structure ssSTErroImport;


public static implicit operator ST_37eba272293c59d7cf1400fbd0fb4b40Structure( RC_a3650876f3c0ce24e984510abde7b989 r) {
return r.ssSTErroImport;
}

public static implicit operator RC_a3650876f3c0ce24e984510abde7b989 (ST_37eba272293c59d7cf1400fbd0fb4b40Structure r) {
RC_a3650876f3c0ce24e984510abde7b989 res = new RC_a3650876f3c0ce24e984510abde7b989 ();
res.ssSTErroImport = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a3650876f3c0ce24e984510abde7b989() {
OptimizedAttributes = null;
ssSTErroImport = new ST_37eba272293c59d7cf1400fbd0fb4b40Structure();
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
    ssSTErroImport.OptimizedAttributes = value[0];
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
ssSTErroImport.Read( r, ref index);
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
public void ReadIM(RC_a3650876f3c0ce24e984510abde7b989 r) {
this = r;
}


public static bool operator == (RC_a3650876f3c0ce24e984510abde7b989 a, RC_a3650876f3c0ce24e984510abde7b989 b) {
if (a.ssSTErroImport != b.ssSTErroImport) return false;
return true;
}

public static bool operator != (RC_a3650876f3c0ce24e984510abde7b989 a, RC_a3650876f3c0ce24e984510abde7b989 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a3650876f3c0ce24e984510abde7b989)) return false;
return (this == (RC_a3650876f3c0ce24e984510abde7b989)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTErroImport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTErroImport.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTErroImport.InternalRecursiveSave();
}


public RC_a3650876f3c0ce24e984510abde7b989 Duplicate() {
RC_a3650876f3c0ce24e984510abde7b989 t;
t.ssSTErroImport = (ST_37eba272293c59d7cf1400fbd0fb4b40Structure)this.ssSTErroImport.Duplicate();
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
if (head == "erroimport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErroImport")) variable.Value = ssSTErroImport; else variable.Optimized = true;
variable.SetFieldName("erroimport");
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
if (key == IdErroImport) {
return ssSTErroImport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdErroImport.Key.AsGuid) {
return ssSTErroImport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTErroImport.FillFromOther((IRecord) other.AttributeGet(IdErroImport));
}
} // RC_a3650876f3c0ce24e984510abde7b989
/// <summary>
/// RecordList type <code>ErroImportRecordList</code> that represents a record list of
///  <code>ErroImport</code>
/// </summary>
public partial class RL_5b9a88f4e44a2321443df94800438b28 : GenericRecordList<RC_a3650876f3c0ce24e984510abde7b989>, IEnumerable, IEnumerator {

protected override RC_a3650876f3c0ce24e984510abde7b989 GetElementDefaultValue() {
return new RC_a3650876f3c0ce24e984510abde7b989();
}

public T[] ToArray<T>(Func<RC_a3650876f3c0ce24e984510abde7b989, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5b9a88f4e44a2321443df94800438b28 recordList, Func<RC_a3650876f3c0ce24e984510abde7b989, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5b9a88f4e44a2321443df94800438b28(RC_a3650876f3c0ce24e984510abde7b989[] array) {
  RL_5b9a88f4e44a2321443df94800438b28 result = new RL_5b9a88f4e44a2321443df94800438b28();
result.InnerFromArray(array);
    return result;
}

public static RL_5b9a88f4e44a2321443df94800438b28 ToList<T>(T[] array, Func <T, RC_a3650876f3c0ce24e984510abde7b989> converter) {
  RL_5b9a88f4e44a2321443df94800438b28 result = new RL_5b9a88f4e44a2321443df94800438b28();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5b9a88f4e44a2321443df94800438b28 FromRestList<T>(RestList<T> restList, Func <T, RC_a3650876f3c0ce24e984510abde7b989> converter) {
  RL_5b9a88f4e44a2321443df94800438b28 result = new RL_5b9a88f4e44a2321443df94800438b28();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5b9a88f4e44a2321443df94800438b28() : base() {
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
protected override OSList<RC_a3650876f3c0ce24e984510abde7b989> NewList() {
return new RL_5b9a88f4e44a2321443df94800438b28();
}


} // RL_5b9a88f4e44a2321443df94800438b28
}

