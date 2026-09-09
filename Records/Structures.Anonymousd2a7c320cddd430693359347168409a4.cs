namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (IMOn0t3NBkOTNZNHFoQJpA)
///  <code>RC_6d8d0ab8b7a86a24d5f4b91570ad61d9</code> that represents <code>ErrorMessage2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: ErrorMessage2Record
public partial struct RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 : ITypedRecord<RC_6d8d0ab8b7a86a24d5f4b91570ad61d9> {
internal static readonly GlobalObjectKey IdErrorMessage2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uAqNbai3JGrV9LkVcK1h2Q");

public ST_50c794173b7ac3485b1cda7be99f6b43Structure ssSTErrorMessage2;


public static implicit operator ST_50c794173b7ac3485b1cda7be99f6b43Structure( RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 r) {
return r.ssSTErrorMessage2;
}

public static implicit operator RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 (ST_50c794173b7ac3485b1cda7be99f6b43Structure r) {
RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 res = new RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 ();
res.ssSTErrorMessage2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6d8d0ab8b7a86a24d5f4b91570ad61d9() {
OptimizedAttributes = null;
ssSTErrorMessage2 = new ST_50c794173b7ac3485b1cda7be99f6b43Structure();
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
    ssSTErrorMessage2.OptimizedAttributes = value[0];
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
ssSTErrorMessage2.Read( r, ref index);
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
public void ReadIM(RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 r) {
this = r;
}


public static bool operator == (RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 a, RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 b) {
if (a.ssSTErrorMessage2 != b.ssSTErrorMessage2) return false;
return true;
}

public static bool operator != (RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 a, RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6d8d0ab8b7a86a24d5f4b91570ad61d9)) return false;
return (this == (RC_6d8d0ab8b7a86a24d5f4b91570ad61d9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTErrorMessage2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTErrorMessage2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTErrorMessage2.InternalRecursiveSave();
}


public RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 Duplicate() {
RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 t;
t.ssSTErrorMessage2 = (ST_50c794173b7ac3485b1cda7be99f6b43Structure)this.ssSTErrorMessage2.Duplicate();
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
if (head == "errormessage2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMessage2")) variable.Value = ssSTErrorMessage2; else variable.Optimized = true;
variable.SetFieldName("errormessage2");
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
if (key == IdErrorMessage2) {
return ssSTErrorMessage2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdErrorMessage2.Key.AsGuid) {
return ssSTErrorMessage2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTErrorMessage2.FillFromOther((IRecord) other.AttributeGet(IdErrorMessage2));
}
} // RC_6d8d0ab8b7a86a24d5f4b91570ad61d9
/// <summary>
/// RecordList type <code>ErrorMessage2RecordList</code> that represents a record list of
///  <code>ErrorMessage2</code>
/// </summary>
public partial class RL_e1bbb6f2318dd9094360b19f393b9afa : GenericRecordList<RC_6d8d0ab8b7a86a24d5f4b91570ad61d9>, IEnumerable, IEnumerator {

protected override RC_6d8d0ab8b7a86a24d5f4b91570ad61d9 GetElementDefaultValue() {
return new RC_6d8d0ab8b7a86a24d5f4b91570ad61d9();
}

public T[] ToArray<T>(Func<RC_6d8d0ab8b7a86a24d5f4b91570ad61d9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e1bbb6f2318dd9094360b19f393b9afa recordList, Func<RC_6d8d0ab8b7a86a24d5f4b91570ad61d9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e1bbb6f2318dd9094360b19f393b9afa(RC_6d8d0ab8b7a86a24d5f4b91570ad61d9[] array) {
  RL_e1bbb6f2318dd9094360b19f393b9afa result = new RL_e1bbb6f2318dd9094360b19f393b9afa();
result.InnerFromArray(array);
    return result;
}

public static RL_e1bbb6f2318dd9094360b19f393b9afa ToList<T>(T[] array, Func <T, RC_6d8d0ab8b7a86a24d5f4b91570ad61d9> converter) {
  RL_e1bbb6f2318dd9094360b19f393b9afa result = new RL_e1bbb6f2318dd9094360b19f393b9afa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e1bbb6f2318dd9094360b19f393b9afa FromRestList<T>(RestList<T> restList, Func <T, RC_6d8d0ab8b7a86a24d5f4b91570ad61d9> converter) {
  RL_e1bbb6f2318dd9094360b19f393b9afa result = new RL_e1bbb6f2318dd9094360b19f393b9afa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e1bbb6f2318dd9094360b19f393b9afa() : base() {
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
protected override OSList<RC_6d8d0ab8b7a86a24d5f4b91570ad61d9> NewList() {
return new RL_e1bbb6f2318dd9094360b19f393b9afa();
}


} // RL_e1bbb6f2318dd9094360b19f393b9afa
}

