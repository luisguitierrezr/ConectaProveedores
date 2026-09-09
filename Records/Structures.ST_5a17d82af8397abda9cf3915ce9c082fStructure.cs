namespace ssConectaProveedores {
/// <summary>
/// [Structure] OrderResult (4aTJ35qDc0ekbejN2GMCAw)
///  <code>ST_5a17d82af8397abda9cf3915ce9c082fStructure</code> that represents <code>OrderResult</code
/// > <p>Description: OrderResult Structure</p>
/// </summary>
// Name: OrderResult
public partial struct ST_5a17d82af8397abda9cf3915ce9c082fStructure : ITypedRecord<ST_5a17d82af8397abda9cf3915ce9c082fStructure> {
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+p3dpjsSikuUiYHQMBqH6A");
internal static readonly GlobalObjectKey IdHasSuccess = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oFLAU4AM7E+rqmagKe8Jmg");
internal static readonly GlobalObjectKey IdErrorMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0dZ7w_nx3kmn0h2E_NLd+w");

public string ssOrderNumber;

public bool ssHasSuccess;

public string ssErrorMessage;


public BitArray OptimizedAttributes;

public ST_5a17d82af8397abda9cf3915ce9c082fStructure() {
OptimizedAttributes = null;
ssOrderNumber = "";
ssHasSuccess = false;
ssErrorMessage = "";
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
ssOrderNumber = r.ReadText(index++, "OrderResult.OrderNumber", "");
ssHasSuccess = r.ReadBoolean(index++, "OrderResult.HasSuccess", false);
ssErrorMessage = r.ReadText(index++, "OrderResult.ErrorMessage", "");
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
public void ReadIM(ST_5a17d82af8397abda9cf3915ce9c082fStructure r) {
this = r;
}


public static bool operator == (ST_5a17d82af8397abda9cf3915ce9c082fStructure a, ST_5a17d82af8397abda9cf3915ce9c082fStructure b) {
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssHasSuccess != b.ssHasSuccess) return false;
if (a.ssErrorMessage != b.ssErrorMessage) return false;
return true;
}

public static bool operator != (ST_5a17d82af8397abda9cf3915ce9c082fStructure a, ST_5a17d82af8397abda9cf3915ce9c082fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5a17d82af8397abda9cf3915ce9c082fStructure)) return false;
return (this == (ST_5a17d82af8397abda9cf3915ce9c082fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssHasSuccess.GetHashCode()
 ^ ssErrorMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_5a17d82af8397abda9cf3915ce9c082fStructure Duplicate() {
ST_5a17d82af8397abda9cf3915ce9c082fStructure t;
t.ssOrderNumber = this.ssOrderNumber;
t.ssHasSuccess = this.ssHasSuccess;
t.ssErrorMessage = this.ssErrorMessage;
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
if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "hassuccess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasSuccess")) variable.Value = ssHasSuccess; else variable.Optimized = true;
} else if (head == "errormessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMessage")) variable.Value = ssErrorMessage; else variable.Optimized = true;
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
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdHasSuccess) {
return ssHasSuccess;
}
if (key == IdErrorMessage) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdHasSuccess.Key.AsGuid) {
return ssHasSuccess;
}
if (attributeKey == IdErrorMessage.Key.AsGuid) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssHasSuccess = (bool) other.AttributeGet(IdHasSuccess);
ssErrorMessage = (string) other.AttributeGet(IdErrorMessage);
}
} // ST_5a17d82af8397abda9cf3915ce9c082fStructure
/// <summary>
/// RecordList type <code>OrderResultList</code> that represents a record list of
///  <code>OrderResult</code>
/// </summary>
public partial class RL_ecd22341994dd1ea101bbe55d1315c3f : GenericRecordList<ST_5a17d82af8397abda9cf3915ce9c082fStructure>, IEnumerable, IEnumerator {

protected override ST_5a17d82af8397abda9cf3915ce9c082fStructure GetElementDefaultValue() {
return new ST_5a17d82af8397abda9cf3915ce9c082fStructure();
}

public T[] ToArray<T>(Func<ST_5a17d82af8397abda9cf3915ce9c082fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ecd22341994dd1ea101bbe55d1315c3f recordList, Func<ST_5a17d82af8397abda9cf3915ce9c082fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ecd22341994dd1ea101bbe55d1315c3f(ST_5a17d82af8397abda9cf3915ce9c082fStructure[] array) {
  RL_ecd22341994dd1ea101bbe55d1315c3f result = new RL_ecd22341994dd1ea101bbe55d1315c3f();
result.InnerFromArray(array);
    return result;
}

public static RL_ecd22341994dd1ea101bbe55d1315c3f ToList<T>(T[] array, Func <T, ST_5a17d82af8397abda9cf3915ce9c082fStructure> converter) {
  RL_ecd22341994dd1ea101bbe55d1315c3f result = new RL_ecd22341994dd1ea101bbe55d1315c3f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ecd22341994dd1ea101bbe55d1315c3f FromRestList<T>(RestList<T> restList, Func <T, ST_5a17d82af8397abda9cf3915ce9c082fStructure> converter) {
  RL_ecd22341994dd1ea101bbe55d1315c3f result = new RL_ecd22341994dd1ea101bbe55d1315c3f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ecd22341994dd1ea101bbe55d1315c3f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_5a17d82af8397abda9cf3915ce9c082fStructure> NewList() {
return new RL_ecd22341994dd1ea101bbe55d1315c3f();
}


} // RL_ecd22341994dd1ea101bbe55d1315c3f
}

