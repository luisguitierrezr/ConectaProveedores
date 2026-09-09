namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (mzewcd8I+0i47veXNTKGjw)
///  <code>RC_9b26d66c2c2462dead9020a39a074a2b</code> that represents <code>DocumentRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DocumentRecord
public partial struct RC_9b26d66c2c2462dead9020a39a074a2b : ITypedRecord<RC_9b26d66c2c2462dead9020a39a074a2b> {
internal static readonly GlobalObjectKey IdDocument = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bNYmmyQs3mKtkCCjmgdKKw");

public string ssDocument;


public BitArray OptimizedAttributes;

public RC_9b26d66c2c2462dead9020a39a074a2b() {
OptimizedAttributes = null;
ssDocument = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssDocument = r.ReadText(index++, "DocumentRecord.Document", "");
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
public void ReadIM(RC_9b26d66c2c2462dead9020a39a074a2b r) {
this = r;
}


public static bool operator == (RC_9b26d66c2c2462dead9020a39a074a2b a, RC_9b26d66c2c2462dead9020a39a074a2b b) {
if (a.ssDocument != b.ssDocument) return false;
return true;
}

public static bool operator != (RC_9b26d66c2c2462dead9020a39a074a2b a, RC_9b26d66c2c2462dead9020a39a074a2b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9b26d66c2c2462dead9020a39a074a2b)) return false;
return (this == (RC_9b26d66c2c2462dead9020a39a074a2b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDocument.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_9b26d66c2c2462dead9020a39a074a2b Duplicate() {
RC_9b26d66c2c2462dead9020a39a074a2b t;
t.ssDocument = this.ssDocument;
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
if (head == "document") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Document")) variable.Value = ssDocument; else variable.Optimized = true;
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
if (key == IdDocument) {
return ssDocument;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDocument.Key.AsGuid) {
return ssDocument;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssDocument = (string) other.AttributeGet(IdDocument);
}
} // RC_9b26d66c2c2462dead9020a39a074a2b
/// <summary>
/// RecordList type <code>DocumentRecordList</code> that represents a record list of <code>Text</code>
/// </summary>
public partial class RL_d9f83b71a68be75785bb65af54dd24f1 : GenericRecordList<RC_9b26d66c2c2462dead9020a39a074a2b>, IEnumerable, IEnumerator {

protected override RC_9b26d66c2c2462dead9020a39a074a2b GetElementDefaultValue() {
return new RC_9b26d66c2c2462dead9020a39a074a2b();
}

public T[] ToArray<T>(Func<RC_9b26d66c2c2462dead9020a39a074a2b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d9f83b71a68be75785bb65af54dd24f1 recordList, Func<RC_9b26d66c2c2462dead9020a39a074a2b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d9f83b71a68be75785bb65af54dd24f1(RC_9b26d66c2c2462dead9020a39a074a2b[] array) {
  RL_d9f83b71a68be75785bb65af54dd24f1 result = new RL_d9f83b71a68be75785bb65af54dd24f1();
result.InnerFromArray(array);
    return result;
}

public static RL_d9f83b71a68be75785bb65af54dd24f1 ToList<T>(T[] array, Func <T, RC_9b26d66c2c2462dead9020a39a074a2b> converter) {
  RL_d9f83b71a68be75785bb65af54dd24f1 result = new RL_d9f83b71a68be75785bb65af54dd24f1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d9f83b71a68be75785bb65af54dd24f1 FromRestList<T>(RestList<T> restList, Func <T, RC_9b26d66c2c2462dead9020a39a074a2b> converter) {
  RL_d9f83b71a68be75785bb65af54dd24f1 result = new RL_d9f83b71a68be75785bb65af54dd24f1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d9f83b71a68be75785bb65af54dd24f1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9b26d66c2c2462dead9020a39a074a2b> NewList() {
return new RL_d9f83b71a68be75785bb65af54dd24f1();
}


} // RL_d9f83b71a68be75785bb65af54dd24f1
}

