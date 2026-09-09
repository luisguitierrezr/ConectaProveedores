namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (C1m86ff8AUajG8TNWvuMog)
///  <code>RC_0601d361b69aac23601da3c9e115bec5</code> that represent
/// s <code>DescriptionShortDescriptionTitleStarIdRecord</code> <p>Description: </p>
/// </summary>
// Name: DescriptionShortDescriptionTitleStarIdRecord
public partial struct RC_0601d361b69aac23601da3c9e115bec5 : ITypedRecord<RC_0601d361b69aac23601da3c9e115bec5> {
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LjJZK8tMkdS7XE_ByZkY+g");
internal static readonly GlobalObjectKey IdShortDescription = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yqCt9YnQEa29b8B3Dh6Neg");
internal static readonly GlobalObjectKey IdTitle = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rmZ9mIpL6x3iA76B1FUGOw");
internal static readonly GlobalObjectKey IdStar = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zPFVQvWmjSGL02rCBr_Jrg");
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qlpy4BQjfmcH+Uf3jKO29g");

public string ssDescription;

public string ssShortDescription;

public string ssTitle;

public bool ssStar;

public long ssId;


public BitArray OptimizedAttributes;

public RC_0601d361b69aac23601da3c9e115bec5() {
OptimizedAttributes = null;
ssDescription = "";
ssShortDescription = "";
ssTitle = "";
ssStar = false;
ssId = 0L;
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
ssDescription = r.ReadText(index++, "DescriptionShortDescriptionTitleStarIdRecord.Description", "");
ssShortDescription = r.ReadText(index++, "DescriptionShortDescriptionTitleStarIdRecord.ShortDescription", "");
ssTitle = r.ReadText(index++, "DescriptionShortDescriptionTitleStarIdRecord.Title", "");
ssStar = r.ReadBoolean(index++, "DescriptionShortDescriptionTitleStarIdRecord.Star", false);
ssId = r.ReadEntityReferenceLongInteger(index++, "DescriptionShortDescriptionTitleStarIdRecord.Id", 0L);
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
public void ReadIM(RC_0601d361b69aac23601da3c9e115bec5 r) {
this = r;
}


public static bool operator == (RC_0601d361b69aac23601da3c9e115bec5 a, RC_0601d361b69aac23601da3c9e115bec5 b) {
if (a.ssDescription != b.ssDescription) return false;
if (a.ssShortDescription != b.ssShortDescription) return false;
if (a.ssTitle != b.ssTitle) return false;
if (a.ssStar != b.ssStar) return false;
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (RC_0601d361b69aac23601da3c9e115bec5 a, RC_0601d361b69aac23601da3c9e115bec5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0601d361b69aac23601da3c9e115bec5)) return false;
return (this == (RC_0601d361b69aac23601da3c9e115bec5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssShortDescription.GetHashCode()
 ^ ssTitle.GetHashCode()
 ^ ssStar.GetHashCode()
 ^ ssId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_0601d361b69aac23601da3c9e115bec5 Duplicate() {
RC_0601d361b69aac23601da3c9e115bec5 t;
t.ssDescription = this.ssDescription;
t.ssShortDescription = this.ssShortDescription;
t.ssTitle = this.ssTitle;
t.ssStar = this.ssStar;
t.ssId = this.ssId;
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
if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "shortdescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortDescription")) variable.Value = ssShortDescription; else variable.Optimized = true;
} else if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Title")) variable.Value = ssTitle; else variable.Optimized = true;
} else if (head == "star") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Star")) variable.Value = ssStar; else variable.Optimized = true;
} else if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
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
if (key == IdDescription) {
return ssDescription;
}
if (key == IdShortDescription) {
return ssShortDescription;
}
if (key == IdTitle) {
return ssTitle;
}
if (key == IdStar) {
return ssStar;
}
if (key == IdId) {
return ssId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdShortDescription.Key.AsGuid) {
return ssShortDescription;
}
if (attributeKey == IdTitle.Key.AsGuid) {
return ssTitle;
}
if (attributeKey == IdStar.Key.AsGuid) {
return ssStar;
}
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssDescription = (string) other.AttributeGet(IdDescription);
ssShortDescription = (string) other.AttributeGet(IdShortDescription);
ssTitle = (string) other.AttributeGet(IdTitle);
ssStar = (bool) other.AttributeGet(IdStar);
ssId = (long) other.AttributeGet(IdId);
}
} // RC_0601d361b69aac23601da3c9e115bec5
/// <summary>
/// RecordList type <code>DescriptionShortDescriptionTitleStarIdRecordList</code> that represents a
///  record list of <code>Text, Text, Text, Boolean, ManualsIdentifier</code>
/// </summary>
public partial class RL_942b1ced293ccdcd219668b20e3afeb8 : GenericRecordList<RC_0601d361b69aac23601da3c9e115bec5>, IEnumerable, IEnumerator {

protected override RC_0601d361b69aac23601da3c9e115bec5 GetElementDefaultValue() {
return new RC_0601d361b69aac23601da3c9e115bec5();
}

public T[] ToArray<T>(Func<RC_0601d361b69aac23601da3c9e115bec5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_942b1ced293ccdcd219668b20e3afeb8 recordList, Func<RC_0601d361b69aac23601da3c9e115bec5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_942b1ced293ccdcd219668b20e3afeb8(RC_0601d361b69aac23601da3c9e115bec5[] array) {
  RL_942b1ced293ccdcd219668b20e3afeb8 result = new RL_942b1ced293ccdcd219668b20e3afeb8();
result.InnerFromArray(array);
    return result;
}

public static RL_942b1ced293ccdcd219668b20e3afeb8 ToList<T>(T[] array, Func <T, RC_0601d361b69aac23601da3c9e115bec5> converter) {
  RL_942b1ced293ccdcd219668b20e3afeb8 result = new RL_942b1ced293ccdcd219668b20e3afeb8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_942b1ced293ccdcd219668b20e3afeb8 FromRestList<T>(RestList<T> restList, Func <T, RC_0601d361b69aac23601da3c9e115bec5> converter) {
  RL_942b1ced293ccdcd219668b20e3afeb8 result = new RL_942b1ced293ccdcd219668b20e3afeb8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_942b1ced293ccdcd219668b20e3afeb8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0601d361b69aac23601da3c9e115bec5> NewList() {
return new RL_942b1ced293ccdcd219668b20e3afeb8();
}


} // RL_942b1ced293ccdcd219668b20e3afeb8
}

