namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (48vTSPGJokO1+PdRvYH5KA)
///  <code>RC_1583d548420c231ffb93458312800446</code> that represents <code>OrderMainRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderMainRecord
public partial struct RC_1583d548420c231ffb93458312800446 : ITypedRecord<RC_1583d548420c231ffb93458312800446> {
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public static implicit operator EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord( RC_1583d548420c231ffb93458312800446 r) {
return r.ssENOrderMain;
}

public static implicit operator RC_1583d548420c231ffb93458312800446 (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord r) {
RC_1583d548420c231ffb93458312800446 res = new RC_1583d548420c231ffb93458312800446 ();
res.ssENOrderMain = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderMain.ChangedAttributes = value;
}
get {
    return ssENOrderMain.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1583d548420c231ffb93458312800446() {
OptimizedAttributes = null;
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderMain.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderMain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_1583d548420c231ffb93458312800446 r) {
this = r;
}


public static bool operator == (RC_1583d548420c231ffb93458312800446 a, RC_1583d548420c231ffb93458312800446 b) {
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_1583d548420c231ffb93458312800446 a, RC_1583d548420c231ffb93458312800446 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1583d548420c231ffb93458312800446)) return false;
return (this == (RC_1583d548420c231ffb93458312800446)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMain.InternalRecursiveSave();
}


public RC_1583d548420c231ffb93458312800446 Duplicate() {
RC_1583d548420c231ffb93458312800446 t;
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderMain.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderMain.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_1583d548420c231ffb93458312800446
/// <summary>
/// RecordList type <code>OrderMainRecordList</code> that represents a record list of
///  <code>OrderMain</code>
/// </summary>
public partial class RL_339e5fbd74448809f3620bf1c8c54b9a : GenericRecordList<RC_1583d548420c231ffb93458312800446>, IEnumerable, IEnumerator {

protected override RC_1583d548420c231ffb93458312800446 GetElementDefaultValue() {
return new RC_1583d548420c231ffb93458312800446();
}

public T[] ToArray<T>(Func<RC_1583d548420c231ffb93458312800446, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_339e5fbd74448809f3620bf1c8c54b9a recordList, Func<RC_1583d548420c231ffb93458312800446, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_339e5fbd74448809f3620bf1c8c54b9a(RC_1583d548420c231ffb93458312800446[] array) {
  RL_339e5fbd74448809f3620bf1c8c54b9a result = new RL_339e5fbd74448809f3620bf1c8c54b9a();
result.InnerFromArray(array);
    return result;
}

public static RL_339e5fbd74448809f3620bf1c8c54b9a ToList<T>(T[] array, Func <T, RC_1583d548420c231ffb93458312800446> converter) {
  RL_339e5fbd74448809f3620bf1c8c54b9a result = new RL_339e5fbd74448809f3620bf1c8c54b9a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_339e5fbd74448809f3620bf1c8c54b9a FromRestList<T>(RestList<T> restList, Func <T, RC_1583d548420c231ffb93458312800446> converter) {
  RL_339e5fbd74448809f3620bf1c8c54b9a result = new RL_339e5fbd74448809f3620bf1c8c54b9a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_339e5fbd74448809f3620bf1c8c54b9a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1583d548420c231ffb93458312800446> NewList() {
return new RL_339e5fbd74448809f3620bf1c8c54b9a();
}


} // RL_339e5fbd74448809f3620bf1c8c54b9a
}

